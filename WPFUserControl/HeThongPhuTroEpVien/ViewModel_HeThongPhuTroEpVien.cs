using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserControl
{
    public class ViewModel_HeThongPhuTroEpVien : ViewModelBase
    { 
        
        #region 1. BĂNG TẢI CẤP LIỆU SÀN LỒNG

        private string view_BangTaiCapLieuSanLongChay = "0";
        public string View_BangTaiCapLieuSanLongChay
        {
            get => view_BangTaiCapLieuSanLongChay;
            set
            {
                view_BangTaiCapLieuSanLongChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_BangTaiCapLieuSanLongLoi = "0";
        public string View_BangTaiCapLieuSanLongLoi
        {
            get => view_BangTaiCapLieuSanLongLoi;
            set
            {
                view_BangTaiCapLieuSanLongLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 2. SÀN LỒNG

        private string view_SanLongChay = "0";
        public string View_SanLongChay
        {
            get => view_SanLongChay;
            set
            {
                view_SanLongChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_SanLongLoi = "0";
        public string View_SanLongLoi
        {
            get => view_SanLongLoi;
            set
            {
                view_SanLongLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 3. VÍT TẢI LẤY LIỆU HỎNG

        private string view_VitTaiLayLieuHongChay = "0";
        public string View_VitTaiLayLieuHongChay
        {
            get => view_VitTaiLayLieuHongChay;
            set
            {
                view_VitTaiLayLieuHongChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_VitTaiLayLieuHongLoi = "0";
        public string View_VitTaiLayLieuHongLoi
        {
            get => view_VitTaiLayLieuHongLoi;
            set
            {
                view_VitTaiLayLieuHongLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 4. BĂNG TẢI LÊN VIÊN NÉN

        private string view_BangTaiLenVienNenChay = "0";
        public string View_BangTaiLenVienNenChay
        {
            get => view_BangTaiLenVienNenChay;
            set
            {
                view_BangTaiLenVienNenChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_BangTaiLenVienNenLoi = "0";
        public string View_BangTaiLenVienNenLoi
        {
            get => view_BangTaiLenVienNenLoi;
            set
            {
                view_BangTaiLenVienNenLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 5. QUẠT LÀM MÁT VIÊN NÉN

        private string view_QuatLamMatVienNenChay = "0";
        public string View_QuatLamMatVienNenChay
        {
            get => view_QuatLamMatVienNenChay;
            set
            {
                view_QuatLamMatVienNenChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_QuatLamMatVienNenLoi = "0";
        public string View_QuatLamMatVienNenLoi
        {
            get => view_QuatLamMatVienNenLoi;
            set
            {
                view_QuatLamMatVienNenLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 6. ALARM        

        private string view_BinChuaVienNenBaoCao = "0";
        public string View_BinChuaVienNenBaoCao
        {
            get => view_BinChuaVienNenBaoCao;
            set
            {
                view_BinChuaVienNenBaoCao = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}
