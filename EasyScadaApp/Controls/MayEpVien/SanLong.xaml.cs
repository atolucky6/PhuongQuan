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
    /// Interaction logic for SanLong.xaml
    /// </summary>
    public partial class SanLong : UserControl
    {
        public SanLong()
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
                motorSanLong.PathToTag = prefix + "DongMayNghien";
                motorBangTai.PathToTag = prefix + "ThoiGianChayMay";
                motorVitTai.PathToTag = prefix + "ThoiGianThayBua";
                btBinChuaVien.PathToTag = prefix + "NangSuat";
                btNamCham.PathToTag = prefix + "DongBangTaiCapLieu";
                btRaVien.PathToTag = prefix + "TanSoBangTaiCapLieu";
            }
        }
    }
}
