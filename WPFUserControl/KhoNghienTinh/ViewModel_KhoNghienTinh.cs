using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserControl
{
    public class ViewModel_KhoNghienTinh : ViewModelBase
    {
        #region 1. XI LANH 1

        private string view_XiLanh1Chay = "0";
        public string View_XiLanh1Chay
        {
            get => view_XiLanh1Chay;
            set
            {
                view_XiLanh1Chay = value;
                RaisePropertyChanged();
            }
        }

        private string view_XiLanh1Tien = "0";
        public string View_XiLanh1Tien
        {
            get => view_XiLanh1Tien;
            set
            {
                view_XiLanh1Tien = value;
                RaisePropertyChanged();
            }
        }

        private string view_XiLanh1Lui = "0";
        public string View_XiLanh1Lui
        {
            get => view_XiLanh1Lui;
            set
            {
                view_XiLanh1Lui = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 2. XI LANH 2

        private string view_XiLanh2Chay = "0";
        public string View_XiLanh2Chay
        {
            get => view_XiLanh2Chay;
            set
            {
                view_XiLanh2Chay = value;
                RaisePropertyChanged();
            }
        }

        private string view_XiLanh2Tien = "0";
        public string View_XiLanh2Tien
        {
            get => view_XiLanh2Tien;
            set
            {
                view_XiLanh2Tien = value;
                RaisePropertyChanged();
            }
        }

        private string view_XiLanh2Lui = "0";
        public string View_XiLanh2Lui
        {
            get => view_XiLanh2Lui;
            set
            {
                view_XiLanh2Lui = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 3. VÍT TẢI CẤP LIỆU 1

        private string view_VitTaiCapLieu1Chay = "0";
        public string View_VitTaiCapLieu1Chay
        {
            get => view_VitTaiCapLieu1Chay;
            set
            {
                view_VitTaiCapLieu1Chay = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiCapLieu1ChayThuan = "0";
        public string View_VitTaiCapLieu1ChayThuan
        {
            get => view_VitTaiCapLieu1ChayThuan;
            set
            {
                view_VitTaiCapLieu1ChayThuan = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiCapLieu1ChayNghich = "0";
        public string View_VitTaiCapLieu1ChayNghich
        {
            get => view_VitTaiCapLieu1ChayNghich;
            set
            {
                view_VitTaiCapLieu1ChayNghich = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiCapLieu1Loi = "0";
        public string View_VitTaiCapLieu1Loi
        {
            get => view_VitTaiCapLieu1Loi;
            set
            {
                view_VitTaiCapLieu1Loi = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiCapLieu1BaoDay = "0";
        public string View_VitTaiCapLieu1BaoDay
        {
            get => view_VitTaiCapLieu1BaoDay;
            set
            {
                view_VitTaiCapLieu1BaoDay = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 4. VÍT TẢI CẤP LIỆU 2

        private string view_VitTaiCapLieu2Chay = "0";
        public string View_VitTaiCapLieu2Chay
        {
            get => view_VitTaiCapLieu2Chay;
            set
            {
                view_VitTaiCapLieu2Chay = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiCapLieu2ChayThuan = "0";
        public string View_VitTaiCapLieu2ChayThuan
        {
            get => view_VitTaiCapLieu2ChayThuan;
            set
            {
                view_VitTaiCapLieu2ChayThuan = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiCapLieu2ChayNghich = "0";
        public string View_VitTaiCapLieu2ChayNghich
        {
            get => view_VitTaiCapLieu2ChayNghich;
            set
            {
                view_VitTaiCapLieu2ChayNghich = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiCapLieu2Loi = "0";
        public string View_VitTaiCapLieu2Loi
        {
            get => view_VitTaiCapLieu2Loi;
            set
            {
                view_VitTaiCapLieu2Loi = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiCapLieu2BaoDay = "0";
        public string View_VitTaiCapLieu2BaoDay
        {
            get => view_VitTaiCapLieu2BaoDay;
            set
            {
                view_VitTaiCapLieu2BaoDay = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 5. VÍT TẢI RA LIỆU

        private string view_VitTaiRaLieuChay = "0";
        public string View_VitTaiRaLieuChay
        {
            get => view_VitTaiRaLieuChay;
            set
            {
                view_VitTaiRaLieuChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiRaLieuQuaDong = "0";
        public string View_VitTaiRaLieuQuaDong
        {
            get => view_VitTaiRaLieuQuaDong;
            set
            {
                view_VitTaiRaLieuQuaDong = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 6. BƠM DẦU

        private string view_BomDauChay = "0";
        public string View_BomDauChay
        {
            get => view_BomDauChay;
            set
            {
                view_BomDauChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_BomDauQuaDong = "0";
        public string View_BomDauQuaDong
        {
            get => view_BomDauQuaDong;
            set
            {
                view_BomDauQuaDong = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 7. BỒN DẦU

        private string view_BonDauQuaNhiet = "0";
        public string View_BonDauQuaNhiet
        {
            get => view_BonDauQuaNhiet;
            set
            {
                view_BonDauQuaNhiet = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 8. CYCLON 1

        private string view_Cyclon1BaoDay = "0";
        public string View_Cyclon1BaoDay
        {
            get => view_Cyclon1BaoDay;
            set
            {
                view_Cyclon1BaoDay = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 9. CYCLON 2

        private string view_Cyclon2BaoDay = "0";
        public string View_Cyclon2BaoDay
        {
            get => view_Cyclon2BaoDay;
            set
            {
                view_Cyclon2BaoDay = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 10. ROTOVAN 1

        private string view_Rotovan1Chay = "0";
        public string View_Rotovan1Chay
        {
            get => view_Rotovan1Chay;
            set
            {
                view_Rotovan1Chay = value;
                RaisePropertyChanged();
            }
        }

        private string view_Rotovan1Loi = "0";
        public string View_Rotovan1Loi
        {
            get => view_Rotovan1Loi;
            set
            {
                view_Rotovan1Loi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 11. ROTOVAN 2

        private string view_Rotovan2Chay = "0";
        public string View_Rotovan2Chay
        {
            get => view_Rotovan2Chay;
            set
            {
                view_Rotovan2Chay = value;
                RaisePropertyChanged();
            }
        }

        private string view_Rotovan2Loi = "0";
        public string View_Rotovan2Loi
        {
            get => view_Rotovan2Loi;
            set
            {
                view_Rotovan2Loi = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}
