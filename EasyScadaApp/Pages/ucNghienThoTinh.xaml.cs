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

namespace EasyScadaApp.Pages
{
    /// <summary>
    /// Interaction logic for ucNghienThoTinh.xaml
    /// </summary>
    public partial class ucNghienThoTinh : UserControl
    {
        public ucNghienThoTinh()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private bool isLoaded;

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (!isLoaded)
            {
                isLoaded = true;

                thongTinMayNghienTho1.StationName = "RemoteStation1";
                thongTinMayNghienTho1.ChannelName = "PLCNghien";
                thongTinMayNghienTho1.DeviceName = "MayNghienTho1";
                thongTinGoiBiNghienTho1.StationName = "RemoteStation1";
                thongTinGoiBiNghienTho1.ChannelName = "PLCNghien";
                thongTinGoiBiNghienTho1.DeviceName = "MayNghienTho1";
                NghienTho1.StationName = "RemoteStation1";
                NghienTho1.ChannelName = "PLCNghien";
                NghienTho1.DeviceName = "MayNghienTho1";
                NghienTho1.BangTaiCapLieuClick += OnBangTaiCapLieuClick;
                NghienTho1.BangTaiTuClick += OnBangTaiTuClick;
                NghienTho1.MotorMayNghienClick += OnMotorMayNghienClick;
                NghienTho1.MotorQuatHutClick += OnMotorQuatHutClick;

                thongTinMayNghienTho2.StationName = "RemoteStation1";
                thongTinMayNghienTho2.ChannelName = "PLCNghien";
                thongTinMayNghienTho2.DeviceName = "MayNghienTho2";
                thongTinGoiBiNghienTho2.StationName = "RemoteStation1";
                thongTinGoiBiNghienTho2.ChannelName = "PLCNghien";
                thongTinGoiBiNghienTho2.DeviceName = "MayNghienTho2";
                NghienTho2.StationName = "RemoteStation1";
                NghienTho2.ChannelName = "PLCNghien";
                NghienTho2.DeviceName = "MayNghienTho2";
                NghienTho2.BangTaiCapLieuClick += OnBangTaiCapLieuClick;
                NghienTho2.BangTaiTuClick += OnBangTaiTuClick;
                NghienTho2.MotorMayNghienClick += OnMotorMayNghienClick;
                NghienTho2.MotorQuatHutClick += OnMotorQuatHutClick;

                thongTinMayNghienTho3.StationName = "RemoteStation1";
                thongTinMayNghienTho3.ChannelName = "PLCNghien";
                thongTinMayNghienTho3.DeviceName = "MayNghienTho3";
                thongTinGoiBiNghienTho3.StationName = "RemoteStation1";
                thongTinGoiBiNghienTho3.ChannelName = "PLCNghien";
                thongTinGoiBiNghienTho3.DeviceName = "MayNghienTho3";
                NghienTho3.StationName = "RemoteStation1";
                NghienTho3.ChannelName = "PLCNghien";
                NghienTho3.DeviceName = "MayNghienTho3";
                NghienTho3.BangTaiCapLieuClick += OnBangTaiCapLieuClick;
                NghienTho3.BangTaiTuClick += OnBangTaiTuClick;
                NghienTho3.MotorMayNghienClick += OnMotorMayNghienClick;
                NghienTho3.MotorQuatHutClick += OnMotorQuatHutClick;

                thongTinMayNghienTho4.StationName = "RemoteStation1";
                thongTinMayNghienTho4.ChannelName = "PLCNghien";
                thongTinMayNghienTho4.DeviceName = "MayNghienTho4";
                thongTinGoiBiNghienTho4.StationName = "RemoteStation1";
                thongTinGoiBiNghienTho4.ChannelName = "PLCNghien";
                thongTinGoiBiNghienTho4.DeviceName = "MayNghienTho4";
                NghienTho4.StationName = "RemoteStation1";
                NghienTho4.ChannelName = "PLCNghien";
                NghienTho4.DeviceName = "MayNghienTho4";
                NghienTho4.BangTaiCapLieuClick += OnBangTaiCapLieuClick;
                NghienTho4.BangTaiTuClick += OnBangTaiTuClick;
                NghienTho4.MotorMayNghienClick += OnMotorMayNghienClick;
                NghienTho4.MotorQuatHutClick += OnMotorQuatHutClick;

                thongTinMayNghienTinh1.StationName = "RemoteStation1";
                thongTinMayNghienTinh1.ChannelName = "PLCNghien";
                thongTinMayNghienTinh1.DeviceName = "MayNghienTinh1";
                thongTinGoiBiNghienTinh1.StationName = "RemoteStation1";
                thongTinGoiBiNghienTinh1.ChannelName = "PLCNghien";
                thongTinGoiBiNghienTinh1.DeviceName = "MayNghienTinh1";
                NghienTinh1.StationName = "RemoteStation1";
                NghienTinh1.ChannelName = "PLCNghien";
                NghienTinh1.DeviceName = "MayNghienTinh1";
                NghienTinh1.MotorMayNghienClick += NghienTinh1_MotorMayNghienClick;
                NghienTinh1.MotorQuatHutClick += NghienTinh1_MotorQuatHutClick;
                NghienTinh1.MotorVitTaiClick += NghienTinh1_MotorVitTaiClick;

                thongTinMayNghienTinh2.StationName = "RemoteStation1";
                thongTinMayNghienTinh2.ChannelName = "PLCNghien";
                thongTinMayNghienTinh2.DeviceName = "MayNghienTinh2";
                thongTinGoiBiNghienTinh2.StationName = "RemoteStation1";
                thongTinGoiBiNghienTinh2.ChannelName = "PLCNghien";
                thongTinGoiBiNghienTinh2.DeviceName = "MayNghienTinh2";
                NghienTinh2.StationName = "RemoteStation1";
                NghienTinh2.ChannelName = "PLCNghien";
                NghienTinh2.DeviceName = "MayNghienTinh2";
                NghienTinh2.MotorMayNghienClick += NghienTinh1_MotorMayNghienClick;
                NghienTinh2.MotorQuatHutClick += NghienTinh1_MotorQuatHutClick;
                NghienTinh2.MotorVitTaiClick += NghienTinh1_MotorVitTaiClick;

                thongTinMayNghienTho1.Start();
                thongTinMayNghienTho2.Start();
                thongTinMayNghienTho3.Start();
                thongTinMayNghienTho4.Start();
                thongTinMayNghienTinh1.Start();
                thongTinMayNghienTinh2.Start();

                thongTinGoiBiNghienTho1.Start();
                thongTinGoiBiNghienTho2.Start();
                thongTinGoiBiNghienTho3.Start();
                thongTinGoiBiNghienTho4.Start();
                thongTinGoiBiNghienTinh1.Start();
                thongTinGoiBiNghienTinh2.Start();

                NghienTho1.Start();
                NghienTho2.Start();
                NghienTho3.Start();
                NghienTho4.Start();
                NghienTinh1.Start();
                NghienTinh2.Start();
            }
        }

        private void NghienTinh1_MotorVitTaiClick(object sender, EventArgs e)
        {
            if (e is MouseButtonEventArgs args)
            {
                string stationName = "RemoteStation1";
                string channelName = "PLCNghien";
                string deviceName = "";
                string resetAlarmTagName = "ResetAlarmHeThong";
                string autoTagName = "CheDoAuto";
                string manualTagName = "CheDoManual";
                string alarmtagName = "BaoAlarmHeThong";
                string title = "";
                if (sender.Equals(NghienTinh1))
                {
                    deviceName = "MayNghienTinh1";
                    title = "Bảng điều khiển - Nghiền Tinh 1";
                }
                else if (sender.Equals(NghienTinh2))
                {
                    deviceName = "MayNghienTinh2";
                    title = "Bảng điều khiển - Nghiền Tinh 2";
                }

                Point clickPoint = args.GetPosition(Application.Current.MainWindow);
                BangDieuKhienMayNghien bangDK = new BangDieuKhienMayNghien();
                bangDK.Start(stationName, channelName, deviceName, autoTagName, manualTagName, alarmtagName, resetAlarmTagName);
                DialogService.Instance.Show(bangDK, clickPoint, title);
            }
        }

        private void NghienTinh1_MotorQuatHutClick(object sender, EventArgs e)
        {
            if (e is MouseButtonEventArgs args)
            {
                string stationName = "RemoteStation1";
                string channelName = "PLCNghien";
                string deviceName = "";
                string resetAlarmTagName = "ResetAlarmHeThong";
                string autoTagName = "CheDoAuto";
                string manualTagName = "CheDoManual";
                string alarmtagName = "BaoAlarmHeThong";
                string title = "";
                if (sender.Equals(NghienTinh1))
                {
                    deviceName = "MayNghienTinh1";
                    title = "Bảng điều khiển - Nghiền Tinh 1";
                }
                else if (sender.Equals(NghienTinh2))
                {
                    deviceName = "MayNghienTinh2";
                    title = "Bảng điều khiển - Nghiền Tinh 2";
                }

                Point clickPoint = args.GetPosition(Application.Current.MainWindow);
                BangDieuKhienMayNghien bangDK = new BangDieuKhienMayNghien();
                bangDK.Start(stationName, channelName, deviceName, autoTagName, manualTagName, alarmtagName, resetAlarmTagName);
                DialogService.Instance.Show(bangDK, clickPoint, title);
            }
        }

        private void NghienTinh1_MotorMayNghienClick(object sender, EventArgs e)
        {
            if (e is MouseButtonEventArgs args)
            {
                string stationName = "RemoteStation1";
                string channelName = "PLCNghien";
                string deviceName = "";
                string resetAlarmTagName = "ResetAlarmHeThong";
                string autoTagName = "CheDoAuto";
                string manualTagName = "CheDoManual";
                string alarmtagName = "BaoAlarmHeThong";
                string title = "";
                if (sender.Equals(NghienTinh1))
                {
                    deviceName = "MayNghienTinh1";
                    title = "Bảng điều khiển - Nghiền Tinh 1";
                }
                else if (sender.Equals(NghienTinh2))
                {
                    deviceName = "MayNghienTinh2";
                    title = "Bảng điều khiển - Nghiền Tinh 2";
                }

                Point clickPoint = args.GetPosition(Application.Current.MainWindow);
                BangDieuKhienMayNghien bangDK = new BangDieuKhienMayNghien();
                bangDK.Start(stationName, channelName, deviceName, autoTagName, manualTagName, alarmtagName, resetAlarmTagName);
                DialogService.Instance.Show(bangDK, clickPoint, title);
            }
        }

        private void OnMotorQuatHutClick(object sender, EventArgs e)
        {
            if (e is MouseButtonEventArgs args)
            {
                string stationName = "RemoteStation1";
                string channelName = "PLCNghien";
                string deviceName = "";
                string resetAlarmTagName = "ResetAlarmHeThong";
                string autoTagName = "CheDoAuto";
                string manualTagName = "CheDoManual";
                string alarmtagName = "BaoAlarmHeThong";
                string title = "";
                if (sender.Equals(NghienTho1))
                {
                    deviceName = "MayNghienTho1";
                    title = "Bảng điều khiển - Nghiền Thô 1";
                }
                else if (sender.Equals(NghienTho2))
                {
                    deviceName = "MayNghienTho2";
                    title = "Bảng điều khiển - Nghiền Thô 2";
                }
                else if (sender.Equals(NghienTho3))
                {
                    deviceName = "MayNghienTho3";
                    title = "Bảng điều khiển - Nghiền Thô 3";
                }
                else if (sender.Equals(NghienTho4))
                {
                    deviceName = "MayNghienTho4";
                    title = "Bảng điều khiển - Nghiền Thô 4";
                }

                Point clickPoint = args.GetPosition(Application.Current.MainWindow);
                BangDieuKhienMayNghien bangDK = new BangDieuKhienMayNghien();
                bangDK.Start(stationName, channelName, deviceName, autoTagName, manualTagName, alarmtagName, resetAlarmTagName);
                DialogService.Instance.Show(bangDK, clickPoint, title);
            }
        }

        private void OnMotorMayNghienClick(object sender, EventArgs e)
        {
            if (e is MouseButtonEventArgs args)
            {
                string stationName = "RemoteStation1";
                string channelName = "PLCNghien";
                string deviceName = "";
                string resetAlarmTagName = "ResetAlarmHeThong";
                string autoTagName = "CheDoAuto";
                string manualTagName = "CheDoManual";
                string alarmtagName = "BaoAlarmHeThong";
                string title = "";
                if (sender.Equals(NghienTho1))
                {
                    deviceName = "MayNghienTho1";
                    title = "Bảng điều khiển - Nghiền Thô 1";
                }
                else if (sender.Equals(NghienTho2))
                {
                    deviceName = "MayNghienTho2";
                    title = "Bảng điều khiển - Nghiền Thô 2";
                }
                else if (sender.Equals(NghienTho3))
                {
                    deviceName = "MayNghienTho3";
                    title = "Bảng điều khiển - Nghiền Thô 3";
                }
                else if (sender.Equals(NghienTho4))
                {
                    deviceName = "MayNghienTho4";
                    title = "Bảng điều khiển - Nghiền Thô 4";
                }

                Point clickPoint = args.GetPosition(Application.Current.MainWindow);
                BangDieuKhienMayNghien bangDK = new BangDieuKhienMayNghien();
                bangDK.Start(stationName, channelName, deviceName, autoTagName, manualTagName, alarmtagName, resetAlarmTagName);
                DialogService.Instance.Show(bangDK, clickPoint, title);
            }
        }

        private void OnBangTaiTuClick(object sender, EventArgs e)
        {
            if (e is MouseButtonEventArgs args)
            {
                string stationName = "RemoteStation1";
                string channelName = "PLCNghien";
                string deviceName = "";
                string resetAlarmTagName = "ResetAlarmHeThong";
                string autoTagName = "CheDoAuto";
                string manualTagName = "CheDoManual";
                string alarmtagName = "BaoAlarmHeThong";
                string title = "";
                if (sender.Equals(NghienTho1))
                {
                    deviceName = "MayNghienTho1";
                    title = "Bảng điều khiển - Nghiền Thô 1";
                }
                else if (sender.Equals(NghienTho2))
                {
                    deviceName = "MayNghienTho2";
                    title = "Bảng điều khiển - Nghiền Thô 2";
                }
                else if (sender.Equals(NghienTho3))
                {
                    deviceName = "MayNghienTho3";
                    title = "Bảng điều khiển - Nghiền Thô 3";
                }
                else if (sender.Equals(NghienTho4))
                {
                    deviceName = "MayNghienTho4";
                    title = "Bảng điều khiển - Nghiền Thô 4";
                }

                Point clickPoint = args.GetPosition(Application.Current.MainWindow);
                BangDieuKhienMayNghien bangDK = new BangDieuKhienMayNghien();
                bangDK.Start(stationName, channelName, deviceName, autoTagName, manualTagName, alarmtagName, resetAlarmTagName);
                DialogService.Instance.Show(bangDK, clickPoint, title);
            }

        }

        private void OnBangTaiCapLieuClick(object sender, EventArgs e)
        {
            if (e is MouseButtonEventArgs args)
            {
                string stationName = "RemoteStation1";
                string channelName = "PLCNghien";
                string deviceName = "";
                string resetAlarmTagName = "ResetAlarmHeThong";
                string autoTagName = "CheDoAuto";
                string manualTagName = "CheDoManual";
                string alarmtagName = "BaoAlarmHeThong";
                string title = "";
                if (sender.Equals(NghienTho1))
                {
                    deviceName = "MayNghienTho1";
                    title = "Bảng điều khiển - Nghiền Thô 1";
                }
                else if (sender.Equals(NghienTho2))
                {
                    deviceName = "MayNghienTho2";
                    title = "Bảng điều khiển - Nghiền Thô 2";
                }
                else if (sender.Equals(NghienTho3))
                {
                    deviceName = "MayNghienTho3";
                    title = "Bảng điều khiển - Nghiền Thô 3";
                }
                else if (sender.Equals(NghienTho4))
                {
                    deviceName = "MayNghienTho4";
                    title = "Bảng điều khiển - Nghiền Thô 4";
                }

                Point clickPoint = args.GetPosition(Application.Current.MainWindow);
                BangDieuKhienMayNghien bangDK = new BangDieuKhienMayNghien();
                bangDK.Start(stationName, channelName, deviceName, autoTagName, manualTagName, alarmtagName, resetAlarmTagName);
                DialogService.Instance.Show(bangDK, clickPoint, title);
            }

        }
    }
}
