using Base;
using Base.Entities.Statuses;
using Microsoft.Win32;
using PhoenixPoint.Common.Core;
using PhoenixPoint.Geoscape.Entities;
using PhoenixPoint.Geoscape.Levels;
using PhoenixPoint.Tactical.Entities;
using PP_Parser.Eval;
using PP_Parser.Parser;
using PP_Parser.Parser.JsonParser;
using PWRA_GUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PWRA_GUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

        }
        private void Load_Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "All Savefiles|*.sav;*.zsav;*.jsav;*zjsav";

            if (Directory.Exists(@"G:\Test")) // for test
                dialog.InitialDirectory = @"G:\Test";

            dialog.ShowDialog();
                

            if (string.IsNullOrEmpty(dialog.FileName))
                return;

            _load(dialog.FileName);
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "json Savefiles|*.jsav;*zjsav";

            if (Directory.Exists(@"G:\Test")) // for test
                dialog.InitialDirectory = @"G:\Test";

            dialog.ShowDialog();

            if (string.IsNullOrEmpty(dialog.FileName))
                return;

            ConsoleApp8.Program.Save(dialog.FileName);
        }

        private void _load(string path)
        {
            Parser.Instance.Load(path);

            wrap_wallet.Children.Clear();
            wrap_base.Children.Clear();
            wrap_char.Children.Clear();


            if (Evaluation.Instance.IsTacticalMap)
            {
                foreach (var val in Evaluation.Instance.TacticalActors)
                {
                    wrap_char.Children.Add(new TacChar(val.SerializationData.OverrideName.LocalizationKey, val.SerializationData.Stats));
                }
                return;
            }

            if (Evaluation.Instance.IsGeoscapeMap)
            {
                foreach (var item in ((GeoFactionInstanceData)Evaluation.Instance.Playerrwallets.ObjectValue).Wallet.Resources.CollectionValues)
                {
                    var model = new WalletEntryModel(item.Value);
                    var wpfwallet = new WalletEntry(model);
                    wrap_wallet.Children.Add(wpfwallet);
                }
                foreach (var item in Evaluation.Instance.PlayerBases)
                {
                    var model = new BaseModel(item.ObjectValue as GeoSiteInstaceData);
                    var wpfbase = new Base(model);
                    wrap_base.Children.Add(wpfbase);
                }
                foreach (var item in Evaluation.Instance.PlayerGeoCharacters)
                {
                    var model = new CharacterModel(item.ObjectValue as GeoCharacter);
                    var wpfChar = new Char(model);
                    wrap_char.Children.Add(wpfChar);
                }
            }


           
        }
    }
}
