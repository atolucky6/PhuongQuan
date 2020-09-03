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
    /// Interaction logic for ThongTinMayEpVien.xaml
    /// </summary>
    public partial class ThongTinMayEpVien : UserControl
    {
        public string StationName { get; set; }
        public string ChannelName { get; set; }
        public string DeviceName { get; set; }
        public string Header1 { get; set; }
        public string Header2 { get; set; }

        public ThongTinMayEpVien()
        {
            InitializeComponent();
            
        }

        bool isStarted = false;
        public void Start()
        {
            if (!isStarted)
            {
                lbMayEp.Content = Header1;
                lbCapLieu.Content = Header2;
                isStarted = true;
                string prefix = $"{StationName}/{ChannelName}/{DeviceName}/";

                dongMotorMayEp.PathToTag = prefix + "DongMayNghien";
                vitTaiMayEp.PathToTag = prefix + "ThoiGianChayMay";
                vitTaiTronNhao.PathToTag = prefix + "ThoiGianThayBua";
                dongVitTaiCapLieu.PathToTag = prefix + "NangSuat";
                tanSoMotorVitTai.PathToTag = prefix + "DongBangTaiCapLieu";
                tocDoCapLieu.PathToTag = prefix + "TanSoBangTaiCapLieu";
                inputTocDo.PathToTag = prefix + "NhapTanSoBangTaiCapLieu";
            }
        }
    }
}
