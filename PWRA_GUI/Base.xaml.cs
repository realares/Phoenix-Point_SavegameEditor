using PhoenixPoint.Geoscape.Entities;
using PWRA_GUI.Models;
using System;
using System.Collections.Generic;
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
    /// Interaktionslogik für Base.xaml
    /// </summary>
    public partial class Base : UserControl
    {
        public Base()
        {
            InitializeComponent();
        }
        public Base(BaseModel model)
            : this()
        {
            this.DataContext = model;
        }
    }
}
