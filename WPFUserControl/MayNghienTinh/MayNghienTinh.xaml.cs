using EasyScada.Core;
using EasyScada.Wpf.Controls;
using System;
using System.Windows.Controls;
using System.Windows;

namespace WPFUserControl
{
    public partial class MayNghienTinh : UserControl
    {
        public string StationName { get; set; }
        public string ChannelName { get; set; }
        public string DeviceName { get; set; }
        public IEasyDriverConnector Connector { get; set; }
        public bool IsStarted { get; private set; }

        public ITag MotorMayNghienChayThuan { get; set; }
        public ITag MotorMayNghienChayNghich { get; set; }
        public ITag MotorMayNghienLoi { get; set; }
        public ITag MotorVitTaiCapLieu { get; set; }
        public ITag MotorQuatHut { get; set; }
        public ITag GoiBiMayNghienLoiTrai { get; set; }
        public ITag GoiBiMayNghienLoiPhai { get; set; }
        public ITag GoiBiQuatHutLoiTrai { get; set; }
        public ITag GoiBiQuatHutLoiPhai { get; set; }
        public ITag XiLanh { get; set; }
        public ITag NapMayNghienTrai { get; set; }
        public ITag NapMayNghienPhai { get; set; }

        public MayNghienTinh()
        {
            InitializeComponent();
        }

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

                MotorVitTaiCapLieu = GetTag("View_BangTaiCapLieuChay");
                if (MotorVitTaiCapLieu != null)
                {
                    MotorVitTaiCapLieu_ValueChanged(MotorVitTaiCapLieu, new TagValueChangedEventArgs("", MotorVitTaiCapLieu.Value));
                    MotorVitTaiCapLieu.ValueChanged += MotorVitTaiCapLieu_ValueChanged;
                }

                XiLanh = GetTag("XiLanhMayNghien");
                if (XiLanh != null)
                {
                    XiLanh_ValueChanged(XiLanh, new TagValueChangedEventArgs("", XiLanh.Value));
                    XiLanh.ValueChanged += XiLanh_ValueChanged;
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
            });
        }

        private void NapMayNghienTrai_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {

                    napMayNghienPhai.Visibility = Visibility.Visible;
                }
                else
                {
                    napMayNghienPhai.Visibility = Visibility.Collapsed;
                }
            }));
        }

        private void NapMayNghienPhai_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    napMayNghienTrai.Visibility = Visibility.Visible;
                }
                else
                {
                    napMayNghienTrai.Visibility = Visibility.Collapsed;
                }
            }));
        }

        private void XiLanh_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MotorVitTaiCapLieu_ValueChanged(object sender, TagValueChangedEventArgs e)
        {
            DispatcherService.Instance.AddToDispatcherQueue(new Action(() =>
            {
                if (e.NewValue == "1")
                {
                    motorVitTaiCapLieuChay.Visibility = Visibility.Visible;
                    motorVitTaiCapLieuDung.Visibility = Visibility.Collapsed;
                    vitTaiCapLieu.Visibility = Visibility.Visible;
                }
                else
                {
                    motorVitTaiCapLieuChay.Visibility = Visibility.Collapsed;
                    motorVitTaiCapLieuDung.Visibility = Visibility.Visible;
                    vitTaiCapLieu.Visibility = Visibility.Collapsed;
                }
            }));
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

        public event EventHandler MotorMayNghienClick;
        public event EventHandler MotorQuatHutClick;
        public event EventHandler MotorVitTaiClick;

        private void MotorMayNghienChay_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MotorMayNghienClick?.Invoke(this, e);
        }

        private void MotorVitTaiCapLieuChay_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MotorVitTaiClick?.Invoke(this, e);
        }

        private void MotorQuatHutChay_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MotorQuatHutClick?.Invoke(this, e);
        }
    }
}
