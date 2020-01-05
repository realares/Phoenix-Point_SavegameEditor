using Microsoft.Win32;
using PhoenixPoint.Geoscape.Entities;
using PhoenixPoint.Geoscape.Levels;
using PP_Parser.Eval;
using PWRA_GUI.Models;
using System.IO;
using System.Windows;


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
            else
            {

            }

            dialog.ShowDialog();
                

            if (string.IsNullOrEmpty(dialog.FileName))
                return;

           _load(dialog.FileName);

            

        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Gzip Bin Savefile|*.zsav|Bin Savefile|*.sav|Gzip json Savefile|*.zjsav|Json Savefiles|*.jsav";

            if (Directory.Exists(@"G:\Test")) // for test
                dialog.InitialDirectory = @"G:\Test";
            else
            {

            }

            dialog.ShowDialog();

            if (string.IsNullOrEmpty(dialog.FileName))
                return;

            PP_Parser.Parser.Parser.Instance.Save(dialog.FileName);
        }

        private void _load(string path)
        {
            var result = PP_Parser.Parser.Parser.Instance.Load(path);

            switch (result)
            {

                case PP_Parser.Parser.Parser.LoadResultEnum.OK:
                    break;
                case PP_Parser.Parser.Parser.LoadResultEnum.NotCompatible:
                    MessageBox.Show("The savefiles is not yet compatible. The savegame cannot be saved correctly. Please contact me. https://github.com/realares/Phoenix-Point_SavegameEditor");
                    break;

            }
            wrap_wallet.Children.Clear();
            wrap_base.Children.Clear();
            wrap_char.Children.Clear();


            if (Evaluation.Instance.IsTacticalMap)
            {
                foreach (var val in Evaluation.Instance.TacticalActors)
                {
                    wrap_char.Children.Add(new TacChar(val));
                }
                //foreach (var val in Evaluation.Instance.TacticalActors)
                //{
                //    wrap_char.Children.Add(new TacChar(val.SerializationData.OverrideName.LocalizationKey, val.SerializationData.Stats));
                //}
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
