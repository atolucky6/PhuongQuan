using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserControl
{
    public class ViewModel_MayNghienTinh : ViewModelBase
    {
        // 1. MOTTOR MAY NGHIEN - 2. RUOT MAY NGHIEN
        private string view_MotorMayNghienChayThuan = "0";
        public string View_MotorMayNghienChayThuan
        {
            get => view_MotorMayNghienChayThuan;
            set
            {
                view_MotorMayNghienChayThuan = value;
                RaisePropertyChanged();
            }
        }

        private string view_MotorMayNghienChayNghich = "0";
        public string View_MotorMayNghienChayNghich
        {
            get => view_MotorMayNghienChayNghich;
            set
            {
                view_MotorMayNghienChayNghich = value;
                RaisePropertyChanged();
            }
        }

        private string view_MotorMayNghienChay = "0";
        public string View_MotorMayNghienChay
        {
            get => view_MotorMayNghienChay;
            set
            {
                view_MotorMayNghienChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_MotorMayNghienLoi = "0";
        public string View_MotorMayNghienLoi
        {
            get => view_MotorMayNghienLoi;
            set
            {
                view_MotorMayNghienLoi = value;
                RaisePropertyChanged();
            }
        }

        // 3. NAP MAY NGHIEN - 
        private string view_NapMayNghien1Mo = "0";
        public string View_NapMayNghien1Mo
        {
            get => view_NapMayNghien1Mo;
            set
            {
                view_NapMayNghien1Mo = value;
                RaisePropertyChanged();
            }
        }

        private string view_NapMayNghien2Mo = "0";
        public string View_NapMayNghien2Mo
        {
            get => view_NapMayNghien2Mo;
            set
            {
                view_NapMayNghien2Mo = value;
                RaisePropertyChanged();
            }
        }

        // 4. MOTTOR VIT TAI CAP LIEU - 5. VIT TAI CAP LIEU
        private string view_MotorVitTaiCapLieuChay = "0";
        public string View_MotorVitTaiCapLieuChay
        {
            get => view_MotorVitTaiCapLieuChay;
            set
            {
                view_MotorVitTaiCapLieuChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_MotorVitTaiCapLieuLoi = "0";
        public string View_MotorVitTaiCapLieuLoi
        {
            get => view_MotorVitTaiCapLieuLoi;
            set
            {
                view_MotorVitTaiCapLieuLoi = value;
                RaisePropertyChanged();
            }
        }       

        // 6. MOTTOR QUAT HUT - 7. QUAT HUT
        private string view_MotorQuatHutChay = "0";
        public string View_MotorQuatHutChay
        {
            get => view_MotorQuatHutChay;
            set
            {
                view_MotorQuatHutChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_MotorQuatHutLoi = "0";
        public string View_MotorQuatHutLoi
        {
            get => view_MotorQuatHutLoi;
            set
            {
                view_MotorQuatHutLoi = value;
                RaisePropertyChanged();
            }
        }

        // 8. XILANH
        private string view_XiLanhMo = "0";
        public string View_XiLanhMo
        {
            get => view_XiLanhMo;
            set
            {
                view_XiLanhMo = value;
                RaisePropertyChanged();
            }
        }

        // 9. GOI BI
        private string view_GoiBiMayNghienLoi = "0";
        public string View_GoiBiMayNghienLoi
        {
            get => view_GoiBiMayNghienLoi;
            set
            {
                view_GoiBiMayNghienLoi = value;
                RaisePropertyChanged();
            }
        }

        private string view_GoiBiQuatHut1Loi = "0";
        public string View_GoiBiQuatHut1Loi
        {
            get => view_GoiBiQuatHut1Loi;
            set
            {
                view_GoiBiQuatHut1Loi = value;
                RaisePropertyChanged();
            }
        }

        private string view_GoiBiQuatHut2Loi = "0";
        public string View_GoiBiQuatHut2Loi
        {
            get => view_GoiBiQuatHut2Loi;
            set
            {
                view_GoiBiQuatHut2Loi = value;
                RaisePropertyChanged();
            }
        }
    }
}
