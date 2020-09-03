using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserControl
{
    public class ViewModel_HeThongGiuBui : ViewModelBase
    {
        #region 1. QUẠT HÚT

        private string view_QuatHutChay = "0";
        public string View_QuatHutChay
        {
            get => view_QuatHutChay;
            set
            {
                view_QuatHutChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_QuatHutLoi = "0";
        public string View_QuatHutLoi
        {
            get => view_QuatHutLoi;
            set
            {
                view_QuatHutLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 2. VÍT TẢI LẤY LIỆU


        private string view_VitTaiLayLieuChay = "0";
        public string View_VitTaiLayLieuChay
        {
            get => view_VitTaiLayLieuChay;
            set
            {
                view_VitTaiLayLieuChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiLayLieuLoi = "0";
        public string View_VitTaiLayLieuLoi
        {
            get => view_VitTaiLayLieuLoi;
            set
            {
                view_VitTaiLayLieuLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 3. ROVANTO

        private string view_RotovanChay = "0";
        public string View_RotovanChay
        {
            get => view_RotovanChay;
            set
            {
                view_RotovanChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_RotovanLoi = "0";
        public string View_RotovanLoi
        {
            get => view_RotovanLoi;
            set
            {
                view_RotovanLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 4. GIŨ BỤI

        private string view_GiuBuiChay = "0";
        public string View_GiuBuiChay
        {
            get => view_GiuBuiChay;
            set
            {
                view_GiuBuiChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_GiuBuiLoi = "0";
        public string View_GiuBuiLoi
        {
            get => view_GiuBuiLoi;
            set
            {
                view_GiuBuiLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}
