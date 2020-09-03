using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using EasyScada.Core;
using EasyScada.Wpf.Controls;

namespace WPFUserControl
{
    public partial class MayNghienTho : UserControl
    {
        #region ----- PROPERTY USERCONTROL -----

        public string StationName { get; set; }
        public string ChannelName { get; set; }
        public string DeviceName { get; set; }
        public IEasyDriverConnector Connector { get; set; }
        public ITag MotorMayNghienChayThuan { get; set; }
        public ITag MotorMayNghienChayNghich { get; set; }
        public ITag MotorMayNghienLoi { get; set; }
        public ITag MotorBangTaiCapLieu { get; set; }
        public ITag MotorBangTaiTu { get; set; }
        public ITag MotorQuatHut { get; set; }
        public ITag GoiBiMayNghienLoiTrai { get; set; }
        public ITag GoiBiMayNghienLoiPhai { get; set; }
        public ITag GoiBiQuatHutLoiTrai { get; set; }
        public ITag GoiBiQuatHutLoiPhai { get; set; }
        public ITag NapMayNghienTrai { get; set; }
        public ITag NapMayNghienPhai { get; set; }
        public ITag BaoAlarmHeThong { get; set; }

        #endregion ----- PROPERTY USERCONTROL -----        

        #region ----- FUNCTION -----        

        public MayNghienTho()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        public bool IsStarted { get; private set; }

        public void Start()
        {
            if (!IsStarted)
            {
                IsStarted = true;
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
            Dispatcher.Invoke(() =>
            {
                MotorMayNghienChayNghich = GetTag("View_MayNghienChayNghich");
                if (MotorMayNghienChayNghich != null)
                {
                    MotorMayNghienChayNghich_ValueChanged(MotorMayNghienChayNghich, new TagValueChangedEventArgs("", MotorMayNghienChayNghich.Value));
                    MotorMayNghienChayNghich.ValueChanged += MotorMayNghienChayNghich_ValueChanged;
                }

                MotorMayNghienChayThuan = GetTag("View_MayNghienChayThuan");
                if (MotorMayNghienChayThuan != null)
                {
                    MotorMayNghienChayThuan_ValueChanged(MotorMayNghienChayThuan, new TagValueChangedEventArgs("", MotorMayNghienChayThuan.Value));
                    MotorMayNghienChayThuan.ValueChanged += MotorMayNghienChayThuan_ValueChanged;
                }

                MotorBangTaiCapLieu = GetTag("View_BangTaiCapLieuChay");
                if (MotorBangTaiCapLieu != null)
                {
                    MotorBangTaiCapLieu_ValueChanged(MotorBangTaiCapLieu, new TagValueChangedEventArgs("", MotorBangTaiCapLieu.Value));
                    MotorBangTaiCapLieu.ValueChanged += MotorBangTaiCapLieu_ValueChanged;
                }

                MotorBangTaiTu = GetTag("View_BangTaiTuChay");
                if (MotorBangTaiTu != null)
                {
                    MotorBangTaiTu_ValueChanged(MotorBangTaiTu, new TagValueChangedEventArgs("", MotorBangTaiTu.Value));
                    MotorBangTaiTu.ValueChanged += MotorBangTaiTu_ValueChanged;
                }

                MotorQuatHut = GetTag("View_QuatHutChay");
                if (MotorQuatHut != null)
                {
                    MotorQuatHut_ValueChanged(MotorQuatHut, new TagValueChangedEventArgs("", MotorQuatHut.Value));
                    MotorQuatHut.ValueChanged += MotorQuatHut_ValueChanged;
                }

                GoiBiMayNghienLoiTrai = GetTag("GoiBiTraiMayNghienQuaNhiet");
                if (GoiBiMayNghienLoiTrai != null)
                {
                    GoiBiMayNghienLoiValueChanged(GoiBiMayNghienLoiTrai, new TagValueChangedEventArgs("", GoiBiMayNghienLoiTrai.Value));
                    GoiBiMayNghienLoiTrai.ValueChanged += GoiBiMayNghienLoiValueChanged;
                }


                GoiBiMayNghienLoiPhai = GetTag("GoiBiPhaiMayNghienQuaNhiet");
                if (GoiBiMayNghienLoiPhai != null)
                {
                    GoiBiMayNghienLoiValueChanged(GoiBiMayNghienLoiPhai, new TagValueChangedEventArgs("", GoiBiMayNghienLoiPhai.Value));
                    GoiBiMayNghienLoiPhai.ValueChanged += GoiBiMayNghienLoiValueChanged;
                }

                GoiBiQuatHutLoiTrai = GetTag("GoiBiTraiQuatHutQuaNhiet");
                if (GoiBiQuatHutLoiTrai != null)
                {
                    GoiBiQuatHutLoiTrai_ValueChanged(GoiBiQuatHutLoiTrai, new TagValueChangedEventArgs("", GoiBiQuatHutLoiTrai.Value));
                    GoiBiQuatHutLoiTrai.ValueChanged += GoiBiQuatHutLoiTrai_ValueChanged;
                }

                GoiBiQuatHutLoiPhai = GetTag("GoiBiPhaiQuatHutQuaNhiet");
                if (GoiBiQuatHutLoiPhai != null)
                {
                    GoiBiQuatHutLoiPhai_ValueChanged(GoiBiQuatHutLoiPhai, new TagValueChangedEventArgs("", GoiBiQuatHutLoiPhai.Value));
                    GoiBiQuatHutLoiPhai.ValueChanged += GoiBiQuatHutLoiPhai_ValueChanged; ;
                }

                NapMayNghienPhai = GetTag("BaoCamBienNapPhaiMayNghien");
                if (NapMayNghienPhai != null)
                {
                    NapMayNghienPhai_ValueChanged(NapMayNghienPhai, new TagValueChangedEventArgs("", NapMayNghienPhai.Value));
                    NapMayNghienPhai.ValueChanged += NapMayNghienPhai_ValueChanged;
                }

                NapMayNghienTrai = GetTag("BaoCamBienNapTraiMayNghien");
                if (NapMayNghienTrai != null)
                {
                    NapMayNghienTrai_ValueChanged(NapMayNghienTrai, new TagValueChangedEventArgs("", NapMayNghienTrai.Value));
                    NapMayNghienTrai.ValueChanged += NapMayNghienTrai_ValueChanged; 
                }

                BaoAlarmHeThong = GetTag("BaoAlarmHeThong");
                if (BaoAlarmHeThong != null)
                {
                    BaoAlarmHeThong_ValueChanged(BaoAlarmHeThong, new TagValueChangedEventArgs("", BaoAlarmHeThong.Value));
                    BaoAlarmHeThong.ValueChanged += BaoAlarmHeThong_ValueChanged;
                }
            });
        }

        private void BaoAlarmHeThong_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    Error = 1;
                }
                else
                {
                    Error = 0;
                }
            }));
        }

        private void NapMayNghienTrai_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    napMayNgienPhai.Visibility = Visibility.Visible;
                }
                else
                {
                    napMayNgienPhai.Visibility = Visibility.Collapsed;
                }
            }));
        }

        private void NapMayNghienPhai_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    napMayNgienTrai.Visibility = Visibility.Visible;
                }
                else
                {
                    napMayNgienTrai.Visibility = Visibility.Collapsed;
                }
            }));
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void GoiBiQuatHutLoiPhai_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    goiBiQuatHut2.Visibility = Visibility.Visible;
                    lblNhietGoiBiQuatHut2.Visibility = Visibility.Visible;
                }
                else
                {
                    goiBiQuatHut2.Visibility = Visibility.Collapsed;
                    lblNhietGoiBiQuatHut2.Visibility = Visibility.Visible;
                }
            }));
        }

        private void GoiBiQuatHutLoiTrai_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    goiBiQuatHut1.Visibility = Visibility.Visible;
                    lblNhietGoiBiQuatHut1.Visibility = Visibility.Visible;
                }
                else
                {
                    goiBiQuatHut1.Visibility = Visibility.Collapsed;
                    lblNhietGoiBiQuatHut1.Visibility = Visibility.Collapsed;
                }
            }));
        }

        private void GoiBiMayNghienLoiValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (GoiBiMayNghienLoiPhai != null && GoiBiMayNghienLoiTrai != null)
                {
                    if (GoiBiMayNghienLoiPhai.Value == "1" || GoiBiMayNghienLoiTrai.Value == "1")
                    {
                        if (GoiBiMayNghienLoiPhai.Value == "1")
                        {
                            lblNhietGoiBiMayNghien1.Visibility = Visibility.Visible;
                        }
                        else if (GoiBiMayNghienLoiTrai.Value == "1")
                        {
                            lblNhietGoiBiMayNghien2.Visibility = Visibility.Visible;
                        }
                        goiBiMayNghien.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        goiBiMayNghien.Visibility = Visibility.Collapsed;
                        if (GoiBiMayNghienLoiPhai.Value == "0")
                        {
                            lblNhietGoiBiMayNghien1.Visibility = Visibility.Collapsed;
                        }
                        else if (GoiBiMayNghienLoiTrai.Value == "0")
                        {
                            lblNhietGoiBiMayNghien2.Visibility = Visibility.Collapsed;
                        }
                    }
                }
            }));
        }

        private void MotorQuatHut_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    motorQuatHutChay.Visibility = Visibility.Visible;
                    motorQuatHutDung.Visibility = Visibility.Collapsed;
                    quatHut.Visibility = Visibility.Visible;
                }
                else
                {
                    motorQuatHutChay.Visibility = Visibility.Collapsed;
                    motorQuatHutDung.Visibility = Visibility.Visible;
                    quatHut.Visibility = Visibility.Collapsed;
                }
            }));
        }

        private void MotorBangTaiTu_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    motorBangTaiTuChay.Visibility = Visibility.Visible;
                    motorBangTaiTuDung.Visibility = Visibility.Collapsed;
                    bangTaiTu.Visibility = Visibility.Visible;
                }
                else
                {
                    motorBangTaiTuChay.Visibility = Visibility.Collapsed;
                    motorBangTaiTuDung.Visibility = Visibility.Visible;
                    bangTaiTu.Visibility = Visibility.Collapsed;
                }
            }));
        }

        private void MotorBangTaiCapLieu_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    motorBTCapLieuChay.Visibility = Visibility.Visible;
                    bangTaiCapLieu.Visibility = Visibility.Visible;
                    motorBTCapLieuDung.Visibility = Visibility.Collapsed;
                }
                else
                {
                    motorBTCapLieuChay.Visibility = Visibility.Collapsed;
                    bangTaiCapLieu.Visibility = Visibility.Collapsed;
                    motorBTCapLieuDung.Visibility = Visibility.Visible;
                }
            }));
        }

        private void MotorMayNghienChayThuan_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                { 
                    motorMayNghienChayThuan.Visibility = Visibility.Visible;
                    ruotMayNghien.Visibility = Visibility.Visible;
                }
                else
                {
                    motorMayNghienChayThuan.Visibility = Visibility.Collapsed;
                    ruotMayNghien.Visibility = Visibility.Collapsed;
                }

                if (MotorMayNghienChayThuan.Value == "1" || MotorMayNghienChayNghich.Value == "1")
                {
                    motorMayNghienChay.Visibility = Visibility.Visible;
                }
                else
                {
                    motorMayNghienChay.Visibility = Visibility.Collapsed;
                }
            }));
        }

        private void MotorMayNghienChayNghich_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    motoMayNghienChayNghich.Visibility = Visibility.Visible;
                    ruotMayNghien.Visibility = Visibility.Visible;
                }
                else
                {
                    motoMayNghienChayNghich.Visibility = Visibility.Collapsed;
                    ruotMayNghien.Visibility = Visibility.Collapsed;
                }

                if (MotorMayNghienChayThuan.Value == "1" || MotorMayNghienChayNghich.Value == "1")
                {
                    motorMayNghienChay.Visibility = Visibility.Visible;
                }
                else
                {
                    motorMayNghienChay.Visibility = Visibility.Collapsed;
                }
            }));
        }

        public ITag GetTag(string tagName)
        {
            return Connector.GetTag($"{StationName}/{ChannelName}/{DeviceName}/{tagName}");
        }

        #endregion ----- FUNCTION -----

        public event EventHandler BangTaiCapLieuClick;
        public event EventHandler BangTaiTuClick;
        public event EventHandler MotorMayNghienClick;
        public event EventHandler MotorQuatHutClick;

        private void BangTaiCapLieu_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BangTaiCapLieuClick?.Invoke(this, e);
        }

        private void BangTaiTu_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BangTaiTuClick?.Invoke(this, e);
        }

        private void MotorMayNghienChay_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MotorMayNghienClick?.Invoke(this, e);
        }

        private void MotorQuatHutChay_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MotorQuatHutClick?.Invoke(this, e);
        }

        public int Error
        {
            get { return (int)GetValue(ErrorProperty); }
            set { SetValue(ErrorProperty, value); }
        }
        public static readonly DependencyProperty ErrorProperty =
            DependencyProperty.Register("Error", typeof(int), typeof(MayNghienTho), new PropertyMetadata(0));

    }
}
