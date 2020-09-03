using EasyScada.Core;
using EasyScada.Wpf.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for BangDieuKhienMayNghien.xaml
    /// </summary>
    public partial class BangDieuKhienMayNghien : UserControl
    {
        public BangDieuKhienMayNghien()
        {
            InitializeComponent();
            this.Focus();
            this.PreviewKeyDown += BangDieuKhienMayNghien_KeyUp;
            if (this.Parent is DockPanel dock)
                (dock.Parent as Window).PreviewKeyDown += BangDieuKhienMayNghien_KeyUp;
            this.Unloaded += BangDieuKhienMayNghien_Unloaded;
            Loaded += BangDieuKhienMayNghien_Loaded;
        }

        private void BangDieuKhienMayNghien_Loaded(object sender, RoutedEventArgs e)
        {
            btnAuto.Focus();
        }

        private void BangDieuKhienMayNghien_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private void BangDieuKhienMayNghien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                if (this.Parent is Window window)
                    window.Close();
                if (Parent is DockPanel dock)
                {
                    if (dock.Parent is Window w)
                        w.Close();
                }
            }
        }

        public string WriteManualValue { get; set; } = "1";
        public string WriteAutoValue { get; set; } = "1";

        public string StationName { get; set; }
        public string ChannelName { get; set; }
        public string DeviceName { get; set; }

        public string AutoTagName { get; set; }
        public string ManualTagName { get; set; }
        public string AlarmTagName { get; set; }
        public string ResetAlarmTagName { get; set; }

        public ITag AutoTag { get; set; }
        public ITag ManualTag { get; set; }
        public ITag AlarmTag { get; set; }
        public ITag ResetAlarmTag { get; set; }
        public IEasyDriverConnector Connector { get; private set; }

        bool isStarted = false;
        public void Start(
            string stationName, string channelName, string deviceName,
            string autoTagName, string manualTagName,
            string alarmTagName, string resetAlarmTagName)
        {
            if (!isStarted)
            {
                StationName = stationName;
                ChannelName = channelName;
                DeviceName = deviceName;
                AutoTagName = autoTagName;
                ManualTagName = manualTagName;
                AlarmTagName = alarmTagName;
                ResetAlarmTagName = resetAlarmTagName;

                isStarted = true;
                Connector = EasyDriverConnectorProvider.GetEasyDriverConnector();

                if (Connector.IsStarted)
                {
                    Connector_Started(Connector, EventArgs.Empty);
                }
                else
                {
                    Connector.Started += Connector_Started;
                }
            }
        }

        private void Connector_Started(object sender, EventArgs e)
        {
            AutoTag = GetTag(AutoTagName);
            ManualTag = GetTag(ManualTagName);
            AlarmTag = GetTag(AlarmTagName);
            ResetAlarmTag = GetTag(ResetAlarmTagName);


            if (AlarmTag != null)
            {
                AlarmTag_ValueChanged(AlarmTag, new TagValueChangedEventArgs("", AlarmTag.Value));
                AlarmTag.ValueChanged += AlarmTag_ValueChanged;
            }

            if (AutoTag != null)
            {
                btnAuto.Click += BtnAuto_Click;
            }
            else
            {
                DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
                {

                    btnAuto.IsEnabled = false;
                }));
            }

            if (ManualTag != null)
            {
                btnManual.Click += BtnManual_Click;
            }
            else
            {
                DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
                {
                    btnManual.IsEnabled = false;
                }));
            }

            if (ResetAlarmTag != null)
            {
                btnAlarm.Click += BtnAlarm_Click;
            }
            else
            {
                DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
                {
                    btnAlarm.IsEnabled = false;
                }));
            }
        }

        private void BtnAlarm_Click(object sender, RoutedEventArgs e)
        {
            ResetAlarmTag.Write("1");
            Thread.Sleep(100);
            ResetAlarmTag.Write("0");
        }

        private void BtnManual_Click(object sender, RoutedEventArgs e)
        {
            ManualTag.Write(WriteManualValue);
            Thread.Sleep(100);
            ManualTag.Write("0");
        }

        private void BtnAuto_Click(object sender, RoutedEventArgs e)
        {
            ManualTag.Write(WriteAutoValue);
            Thread.Sleep(100);
            ManualTag.Write("0");
        }

        private void AlarmTag_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    btnAlarm.Background = Brushes.Red;
                }
                else
                {
                    btnAlarm.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
                }
            }));
        }

        private void ModeTag_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    lbMode.Background = Brushes.Red;
                }
                else
                {
                    lbMode.Background = Brushes.Black;
                }
            }));
        }

        public ITag GetTag(string tagName)
        {
            return Connector.GetTag($"{StationName}/{ChannelName}/{DeviceName}/{tagName}");
        }
    }
}
