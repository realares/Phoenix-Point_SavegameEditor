using Base.Entities.Statuses;
using PhoenixPoint.Tactical.Entities;
using PP_Parser.Parser;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace PWRA_GUI
{
    /// <summary>
    /// Interaktionslogik für TacChar.xaml
    /// </summary>
    public partial class TacChar : UserControl
    {
        private TacticalActor _context;
        private string _tacCharName;

        public TacChar()
        {
            InitializeComponent();
            Loaded += TacChar_Loaded;
        }
        public TacChar(TacticalActor context)
         : this()
        {
            switch (context.SerializationData.MissionParticipant.EnumName)
            {
                case "Player":
                    border.BorderBrush = System.Windows.Media.Brushes.Green;
                    border.BorderThickness = new Thickness(2);
                    break;
                case "Intruder":
                    border.BorderBrush = System.Windows.Media.Brushes.Red;
                    border.BorderThickness = new Thickness(2);
                    break;
                default:
                    break;
            }
            //val.SerializationData.OverrideName.LocalizationKey, val.SerializationData.Stats
            if (context.SerializationData.OverrideName != null)
                _tacCharName = context.SerializationData.OverrideName.LocalizationKey;
            else
                _tacCharName = context.ActorCreateData.Name;
            _context = context;
        }
//        public TacChar(string name, PhoenixGenericCollection<KnownPhoenixObjectID<StatusStat>> context)
//: this()
//        {
//            _tacCharName = name;
//            _context = context;
//        }


        private void TacChar_Loaded(object sender, RoutedEventArgs e)
        {
            if (_context == null) return;

            SetData();
        }

        public void SetData()
        {
            basestack.Children.Clear();

            TextBlock textBlock_name = new TextBlock()
            {
                Text = _tacCharName,
                Width = 200,
            };

            basestack.Children.Add(textBlock_name);

            foreach (var item in _context.SerializationData.Stats.CollectionValues)
            {
                var o = item.Raw();
                switch (o)
                {
                    case StatusStat sat:
                        {
                            StackPanel stackPanel = new StackPanel()
                            {
                                Orientation = Orientation.Horizontal
                            };
                            TextBlock textBlock1 = new TextBlock()
                            {
                                Text = sat.Name,
                                Width = 150,
                            };

                            TextBox textBlock2 = new TextBox()
                            {
                                Width = 60,
                            };
                            TextBox textBlock3 = new TextBox()
                            {
                                Width = 60,
                            };
                            Binding myBinding = new Binding();
                            myBinding.Source = sat;
                            myBinding.Path = new PropertyPath("Max.Value");
                            myBinding.Mode = BindingMode.TwoWay;
                            myBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                            BindingOperations.SetBinding(textBlock2, TextBox.TextProperty, myBinding);
                            myBinding = new Binding();
                            myBinding.Source = sat;
                            myBinding.Path = new PropertyPath("Value.Value");
                            myBinding.Mode = BindingMode.TwoWay;
                            myBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                            BindingOperations.SetBinding(textBlock3, TextBox.TextProperty, myBinding);

                            stackPanel.Children.Add(textBlock1);
                            stackPanel.Children.Add(textBlock2); 
                            stackPanel.Children.Add(textBlock3);
                            basestack.Children.Add(stackPanel);
                            
                            break;
                        }
                    case BaseStat basestat:
                        {
                            StackPanel stackPanel = new StackPanel()
                            {
                                Orientation = Orientation.Horizontal
                            };
                            TextBlock textBlock1 = new TextBlock()
                            {
                                Text = basestat.Name,
                                Width = 150,
                            };

                            TextBox textBlock2 = new TextBox()
                            {
                                Width = 60,
                            };
                            TextBox textBlock3 = new TextBox()
                            {
                                Width = 60,
                            };
                            Binding myBinding = new Binding();
                            myBinding.Source = basestat;
                            myBinding.Path = new PropertyPath("Value.EndValue");
                            myBinding.Mode = BindingMode.TwoWay;
                            myBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                            BindingOperations.SetBinding(textBlock2, TextBox.TextProperty, myBinding);
                            myBinding = new Binding();
                            myBinding.Source = basestat;
                            myBinding.Path = new PropertyPath("Value.Value");
                            myBinding.Mode = BindingMode.TwoWay;
                            myBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                            BindingOperations.SetBinding(textBlock3, TextBox.TextProperty, myBinding);

                            stackPanel.Children.Add(textBlock1);
                            stackPanel.Children.Add(textBlock2);
                            stackPanel.Children.Add(textBlock3);
                            basestack.Children.Add(stackPanel);

                        }
                        break;

                    default:
                        break;
                }
            }
        }


        private void btnAllToMax_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in _context.SerializationData.Stats.CollectionValues)
            {
                var o = item.Raw();
                switch (o)
                {
                    case StatusStat sat:
                        {
                            //Console.WriteLine($"{sat.Name} : {sat.Max.Value} : {sat.Value.Value}");
                            sat.Value.Value = sat.Max.Value;
                        }
                        break;

                    case BaseStat basestat:
                        //Console.WriteLine($"{basestat.Name} : {basestat.Value.EndValue} : {basestat.Value.Value}");
                        basestat.Value.Value = basestat.Value.Value;
                        break;
                    default:
                        break;
                }
            }
            SetData();
        }
        private void btnAmorToMax_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in _context.SerializationData.Stats.CollectionValues)
            {
                var o = item.Raw();
                switch (o)
                {
                    case StatusStat sat:
                        {
                            if (sat.Name.Contains("_Armor"))
                            {
                                sat.Value.Value = 200;
                                sat.Max.Value = 200;
                            }
                        }
                        break;

                    case BaseStat basestat:
                        if (basestat.Name.Contains("_Armor"))
                        {
                            basestat.Value.Value = 200;
                            basestat.Value.Value = 200;
                        }
                        break;
                    default:
                        break;
                }
            }
            SetData();
        }
    }
}
