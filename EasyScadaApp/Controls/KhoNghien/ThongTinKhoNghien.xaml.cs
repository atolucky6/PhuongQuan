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
    /// Interaction logic for ThongTinKhoNghien.xaml
    /// </summary>
    public partial class ThongTinKhoNghien : UserControl
    {
        public ThongTinKhoNghien()
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
                motor1.PathToTag = prefix + "DongMayNghien";
                motor2.PathToTag = prefix + "ThoiGianChayMay";
                tgChayKho.PathToTag = prefix + "ThoiGianThayBua";
                vitTai1.PathToTag = prefix + "NangSuat";
                vitTai2.PathToTag = prefix + "DongBangTaiCapLieu";
                vitTai3.PathToTag = prefix + "TanSoBangTaiCapLieu";
            }
        }
    }
}
