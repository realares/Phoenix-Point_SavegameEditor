﻿//  MIT License
//  
//  Copyright (c) 2017 Emmanuel Counasse
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//  
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//  
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.

//  Modified
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PP_Parser.Parser;

namespace JsonSubTypes
{
    public class SubtypesForJson : JsonConverter
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
        public class KnownSubTypeAttribute : Attribute
        {
            public Type SubType { get; private set; }
            public object AssociatedValue { get; private set; }

            public KnownSubTypeAttribute(Type subType, object associatedValue)
            {
                SubType = subType;
                AssociatedValue = associatedValue;
            }
        }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
        public class KnownSubTypeWithPropertyAttribute : Attribute
        {
            public Type SubType { get; private set; }
            public string PropertyName { get; private set; }

            public KnownSubTypeWithPropertyAttribute(Type subType, string propertyName)
            {
                SubType = subType;
                PropertyName = propertyName;
            }
        }

        private readonly string _typeMappingPropertyName;
        private readonly bool _useValueTypeMapping;

        private bool _isInsideRead;
        private JsonReader _reader;

        public override bool CanRead
        {
            get
            {
                if (!_isInsideRead)
                    return true;

                return !string.IsNullOrEmpty(_reader.Path);
            }
        }

        public sealed override bool CanWrite
        {
            get { return false; }
        }

        public SubtypesForJson()
        {
        }

        public SubtypesForJson(string typeMappingPropertyName, bool valueTypeMapping = false)
        {
            _typeMappingPropertyName = typeMappingPropertyName;
            _useValueTypeMapping = valueTypeMapping;
        }

        public override bool CanConvert(Type objectType)
        {
            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return ReadJson(reader, objectType, serializer);
        }

        private object ReadJson(JsonReader reader, Type objectType, JsonSerializer serializer)
        {
            while (reader.TokenType == JsonToken.Comment)
                reader.Read();

            object value;
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    value = null;
                    break;
                case JsonToken.StartObject:
                    value = ReadObject(reader, objectType, serializer);
                    break;
                case JsonToken.StartArray:
                    value = ReadArray(reader, objectType, serializer);
                    break;
                default:
                    var lineNumber = 0;
                    var linePosition = 0;
                    var lineInfo = reader as IJsonLineInfo;
                    if (lineInfo != null && lineInfo.HasLineInfo())
                    {
                        lineNumber = lineInfo.LineNumber;
                        linePosition = lineInfo.LinePosition;
                    }

                    return new JsonReaderException(string.Format("Unrecognized token: {0}",
                        reader.TokenType), reader.Path, lineNumber, linePosition, null);
            }

            return value;
        }

        private IList ReadArray(JsonReader reader, Type targetType, JsonSerializer serializer)
        {
            var elementType = GetElementType(targetType);

            var list = CreateCompatibleList(targetType, elementType);
            while (reader.Read() && reader.TokenType != JsonToken.EndArray)
            {
                list.Add(ReadJson(reader, elementType, serializer));
            }

            if (targetType.IsArray)
            {
                var array = Array.CreateInstance(targetType.GetElementType(), list.Count);
                list.CopyTo(array, 0);
                list = array;
            }
            return list;
        }

        private static IList CreateCompatibleList(Type targetContainerType, Type elementType)
        {
            IList list;
            if (targetContainerType.IsArray || targetContainerType.GetTypeInfo().IsAbstract)
            {
                list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(elementType));
            }
            else
            {
                list = (IList)Activator.CreateInstance(targetContainerType);
            }
            return list;
        }

        private static Type GetElementType(Type arrayOrGenericContainer)
        {
            Type elementType;
            if (arrayOrGenericContainer.IsArray)
            {
                elementType = arrayOrGenericContainer.GetElementType();
            }
            else
            {
                elementType = arrayOrGenericContainer.GenericTypeArguments[0];
            }
            return elementType;
        }

        private object ReadObject(JsonReader reader, Type objectType, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);

            var targetType = GetType(jObject, objectType) ?? objectType;

            return _ReadJson(CreateAnotherReader(jObject, reader), targetType, null, serializer);
        }

        private static JsonReader CreateAnotherReader(JObject jObject, JsonReader reader)
        {
            var jObjectReader = jObject.CreateReader();
            jObjectReader.Culture = reader.Culture;
            jObjectReader.CloseInput = reader.CloseInput;
            jObjectReader.SupportMultipleContent = reader.SupportMultipleContent;
            jObjectReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
            jObjectReader.FloatParseHandling = reader.FloatParseHandling;
            jObjectReader.DateFormatString = reader.DateFormatString;
            jObjectReader.DateParseHandling = reader.DateParseHandling;
            return jObjectReader;
        }

        public Type GetType(JObject jObject, Type parentType)
        {
            if (_typeMappingPropertyName == null)
            {
                return GetTypeByPropertyPresence(jObject, parentType);
            }
            return GetTypeFromDiscriminatorValue(jObject, parentType);
        }

        private static Type GetTypeByPropertyPresence(JObject jObject, Type parentType)
        {
            foreach (var type in parentType.GetTypeInfo().GetCustomAttributes<KnownSubTypeWithPropertyAttribute>())
            {
                JToken ignore;
                if (jObject.TryGetValue(type.PropertyName, out ignore))
                {
                    return type.SubType;
                }
            }
            return null;
        }

        private Type GetTypeFromDiscriminatorValue(JObject jObject, Type parentType)
        {
            JToken jToken;
            if (!jObject.TryGetValue(_typeMappingPropertyName, out jToken)) return null;

            var discriminatorValue = jToken.ToObject<object>();
            if (discriminatorValue == null) return null;

            if (_useValueTypeMapping)
            {
                //int a = (int)(long)discriminatorValue;
                if (SubTyper.Instance.TryGetValue((int)(long)discriminatorValue, out Type type))
                //if (_valueTypeMapping.TryGetValue(discriminatorValue, out Type type))
                    return type;
            }
            else
            {
                var typeMapping = GetSubTypeMapping(parentType);
                if (typeMapping.Any())
                {
                    return GetTypeFromMapping(typeMapping, discriminatorValue);
                }
            }
            return GetTypeByName(discriminatorValue as string, parentType);
        }

        public static Type GetTypeByName(string typeName, Type parentType)
        {
            if (typeName == null)
                return null;

            var insideAssembly = parentType.GetTypeInfo().Assembly;

            var typeByName = insideAssembly.GetType(typeName);
    
            if (typeByName == null)
            {
                var searchLocation =
                    parentType.FullName.Substring(0, parentType.FullName.Length - parentType.Name.Length);
                typeByName = insideAssembly.GetType(searchLocation + typeName, false, true);
            }
            if (typeByName == null)
            {
                 typeByName = Type.GetType(typeName);
            }
            return typeByName;
        }

        private static Type GetTypeFromMapping(IReadOnlyDictionary<object, Type> typeMapping, object discriminatorValue)
        {
            var targetlookupValueType = typeMapping.First().Key.GetType();
            var lookupValue = ConvertJsonValueToType(discriminatorValue, targetlookupValueType);

            Type targetType;
            return typeMapping.TryGetValue(lookupValue, out targetType) ? targetType : null;
        }

        private static Dictionary<object, Type> GetSubTypeMapping(Type type)
        {
            return type.GetTypeInfo().GetCustomAttributes<KnownSubTypeAttribute>()
                .ToDictionary(x => x.AssociatedValue, x => x.SubType);
        }

        private static object ConvertJsonValueToType(object objectType, Type targetlookupValueType)
        {
            if (targetlookupValueType.GetTypeInfo().IsEnum)
                return Enum.ToObject(targetlookupValueType, objectType);

            return Convert.ChangeType(objectType, targetlookupValueType);
        }

        protected object _ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            _reader = reader;
            _isInsideRead = true;
            try
            {
                return serializer.Deserialize(reader, objectType);
            }
            finally
            {
                _isInsideRead = false;
            }
        }
    }
}