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

namespace EasyScadaApp
{
    /// <summary>
    /// Interaction logic for ThongTinGoiBi.xaml
    /// </summary>
    public partial class ThongTinGoiBi : UserControl
    {
        public ThongTinGoiBi()
        {
            InitializeComponent();
        }

        public string StationName { get; set; }
        public string ChannelName { get; set; }
        public string DeviceName { get; set; }

        bool isStarted = false;
        public void Start()
        {
            if (!isStarted)
            {
                isStarted = true;
                string prefix = $"{StationName}/{ChannelName}/{DeviceName}/";
                nhietDoGoiBi1.PathToTag = prefix + "NhietDoGoiBiPhaiMayNghien";
                nhietDoGoiBi2.PathToTag = prefix + "NhietDoGoiBiTraiMayNghien";
                nhietDoGoiBi3.PathToTag = prefix + "NhietDoGoiBiPhaiQuatHut";
                nhietDoGoiBi4.PathToTag = prefix + "NhietDoGoiBiTraiQuatHut";
            }
        }
    }
}
