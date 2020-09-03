using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserControl
{
    public class ViewModel_MayNghienTho : ViewModelBase
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

        // 4. MOTTOR BANG TAI CAP LIEU - 5. BANG TAI CAP LIEU
        private string view_MotorBangTaiCapLieuChay = "0";
        public string View_MotorBangTaiCapLieuChay
        {
            get => view_MotorBangTaiCapLieuChay;
            set
            {
                view_MotorBangTaiCapLieuChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_MotorBangTaiCapLieuLoi = "0";
        public string View_MotorBangTaiCapLieuLoi
        {
            get => view_MotorBangTaiCapLieuLoi;
            set
            {
                view_MotorBangTaiCapLieuLoi = value;
                RaisePropertyChanged();
            }
        }

        // 6. MOTTOR BANG TAI TU - 7. BANG TAI TU    
        private string view_MotorBangTaiTuChay = "0";
        public string View_MotorBangTaiTuChay
        {
            get => view_MotorBangTaiTuChay;
            set
            {
                view_MotorBangTaiTuChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_MotorBangTaiTuLoi = "0";
        public string View_MotorBangTaiTuLoi
        {
            get => view_MotorBangTaiTuLoi;
            set
            {
                view_MotorBangTaiTuLoi = value;
                RaisePropertyChanged();
            }
        }

        // 8. MOTTOR QUAT HUT - 9. QUAT HUT
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

        // 10. GOI BI
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
