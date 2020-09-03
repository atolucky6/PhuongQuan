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
    /// Interaction logic for ThongTinCan.xaml
    /// </summary>
    public partial class ThongTinCan : UserControl
    {
        public ThongTinCan()
        {
            InitializeComponent();
        }

        public string StationName { get; set; }
        public string ChannelName { get; set; }
        public string DeviceName { get; set; }
        public string Header { get; set; }

        bool isStarted = false;
        public void Start()
        {
            if (!isStarted)
            {
                lbHeader.Content = Header;  
                isStarted = true;
                string prefix = $"{StationName}/{ChannelName}/{DeviceName}/";
                klCa.PathToTag = prefix + "DongMayNghien";
                klVien.PathToTag = prefix + "ThoiGianChayMay";
            }
        }
    }
}
