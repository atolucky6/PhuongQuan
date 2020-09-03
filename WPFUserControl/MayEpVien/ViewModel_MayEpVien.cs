using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserControl
{
    public class ViewModel_MayEpVien : ViewModelBase
    {
        #region 0. BĂNG TẢI CẤP LIỆU

        private string view_BangTaiCapLieuChay = "0";
        public string View_BangTaiCapLieuChay
        {
            get => view_BangTaiCapLieuChay;
            set
            {
                view_BangTaiCapLieuChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_BangTaiCapLieuLoi = "0";
        public string View_BangTaiCapLieuLoi
        {
            get => view_BangTaiCapLieuLoi;
            set
            {
                view_BangTaiCapLieuLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 1. MÁY ÉP VIÊN 1

        #region FEEDER A
        private string view_EpVien1FeederAChay = "1";
        public string View_EpVien1FeederAChay
        {
            get => view_EpVien1FeederAChay;
            set
            {
                view_EpVien1FeederAChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien1FeederALoi = "1";
        public string View_EpVien1FeederALoi
        {
            get => view_EpVien1FeederALoi;
            set
            {
                view_EpVien1FeederALoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region FEEDER B
        private string view_EpVien1FeederBChay = "1";
        public string View_EpVien1FeederBChay
        {
            get => view_EpVien1FeederBChay;
            set
            {
                view_EpVien1FeederBChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien1FeederBLoi = "1";
        public string View_EpVien1FeederBLoi
        {
            get => view_EpVien1FeederBLoi;
            set
            {
                view_EpVien1FeederBLoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region MIXER
        private string view_EpVien1MixerChay = "1";
        public string View_EpVien1MixerChay
        {
            get => view_EpVien1MixerChay;
            set
            {
                view_EpVien1MixerChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien1MixerLoi = "1";
        public string View_EpVien1MixerLoi
        {
            get => view_EpVien1MixerLoi;
            set
            {
                view_EpVien1MixerLoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region ĐỘNG CƠ CHÍNH

        private string view_EpVien1DongCoChinhChay = "1";
        public string View_EpVien1DongCoChinhChay
        {
            get => view_EpVien1DongCoChinhChay;
            set
            {
                view_EpVien1DongCoChinhChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien1DongCoChinh1Loi = "1";
        public string View_EpVien1DongCoChinh1Loi
        {
            get => view_EpVien1DongCoChinh1Loi;
            set
            {
                view_EpVien1DongCoChinh1Loi = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien1DongCoChinh2Loi = "1";
        public string View_EpVien1DongCoChinh2Loi
        {
            get => view_EpVien1DongCoChinh2Loi;
            set
            {
                view_EpVien1DongCoChinh2Loi = value;
                RaisePropertyChanged();
            }
        }
     
        #endregion

        #endregion

        #region 2. MÁY ÉP VIÊN 2

        #region FEEDER A
        private string view_EpVien2FeederAChay = "1";
        public string View_EpVien2FeederAChay
        {
            get => view_EpVien2FeederAChay;
            set
            {
                view_EpVien2FeederAChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien2FeederALoi = "1";
        public string View_EpVien2FeederALoi
        {
            get => view_EpVien2FeederALoi;
            set
            {
                view_EpVien2FeederALoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region FEEDER B
        private string view_EpVien2FeederBChay = "1";
        public string View_EpVien2FeederBChay
        {
            get => view_EpVien2FeederBChay;
            set
            {
                view_EpVien2FeederBChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien2FeederBLoi = "1";
        public string View_EpVien2FeederBLoi
        {
            get => view_EpVien2FeederBLoi;
            set
            {
                view_EpVien2FeederBLoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region MIXER
        private string view_EpVien2MixerChay = "1";
        public string View_EpVien2MixerChay
        {
            get => view_EpVien2MixerChay;
            set
            {
                view_EpVien2MixerChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien2MixerLoi = "1";
        public string View_EpVien2MixerLoi
        {
            get => view_EpVien2MixerLoi;
            set
            {
                view_EpVien2MixerLoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region ĐỘNG CƠ CHÍNH
        private string view_EpVien2DongCoChinhChay = "1";
        public string View_EpVien2DongCoChinhChay
        {
            get => view_EpVien2DongCoChinhChay;
            set
            {
                view_EpVien2DongCoChinhChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien2DongCoChinh1Loi = "1";
        public string View_EpVien2DongCoChinh1Loi
        {
            get => view_EpVien2DongCoChinh1Loi;
            set
            {
                view_EpVien2DongCoChinh1Loi = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien2DongCoChinh2Loi = "1";
        public string View_EpVien2DongCoChinh2Loi
        {
            get => view_EpVien2DongCoChinh2Loi;
            set
            {
                view_EpVien2DongCoChinh2Loi = value;
                RaisePropertyChanged();
            }
        }
      
        #endregion

        #endregion

        #region 3. MÁY ÉP VIÊN 3

        #region FEEDER A
        private string view_EpVien3FeederAChay = "1";
        public string View_EpVien3FeederAChay
        {
            get => view_EpVien3FeederAChay;
            set
            {
                view_EpVien3FeederAChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien3FeederALoi = "1";
        public string View_EpVien3FeederALoi
        {
            get => view_EpVien3FeederALoi;
            set
            {
                view_EpVien3FeederALoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region FEEDER B
        private string view_EpVien3FeederBChay = "1";
        public string View_EpVien3FeederBChay
        {
            get => view_EpVien3FeederBChay;
            set
            {
                view_EpVien3FeederBChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien3FeederBLoi = "1";
        public string View_EpVien3FeederBLoi
        {
            get => view_EpVien3FeederBLoi;
            set
            {
                view_EpVien3FeederBLoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region MIXER
        private string view_EpVien3MixerChay = "1";
        public string View_EpVien3MixerChay
        {
            get => view_EpVien3MixerChay;
            set
            {
                view_EpVien3MixerChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien3MixerLoi = "1";
        public string View_EpVien3MixerLoi
        {
            get => view_EpVien3MixerLoi;
            set
            {
                view_EpVien3MixerLoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region ĐỘNG CƠ CHÍNH
        private string view_EpVien3DongCoChinhChay = "1";
        public string View_EpVien3DongCoChinhChay
        {
            get => view_EpVien3DongCoChinhChay;
            set
            {
                view_EpVien3DongCoChinhChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien3DongCoChinh1Loi = "1";
        public string View_EpVien3DongCoChinh1Loi
        {
            get => view_EpVien3DongCoChinh1Loi;
            set
            {
                view_EpVien3DongCoChinh1Loi = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien3DongCoChinh2Loi = "1";
        public string View_EpVien3DongCoChinh2Loi
        {
            get => view_EpVien3DongCoChinh2Loi;
            set
            {
                view_EpVien3DongCoChinh2Loi = value;
                RaisePropertyChanged();
            }
        }       
        #endregion

        #endregion

        #region 4. MÁY ÉP VIÊN 4

        #region FEEDER A
        private string view_EpVien4FeederAChay = "1";
        public string View_EpVien4FeederAChay
        {
            get => view_EpVien4FeederAChay;
            set
            {
                view_EpVien4FeederAChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien4FeederALoi = "1";
        public string View_EpVien4FeederALoi
        {
            get => view_EpVien4FeederALoi;
            set
            {
                view_EpVien4FeederALoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region FEEDER B
        private string view_EpVien4FeederBChay = "1";
        public string View_EpVien4FeederBChay
        {
            get => view_EpVien4FeederBChay;
            set
            {
                view_EpVien4FeederBChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien4FeederBLoi = "1";
        public string View_EpVien4FeederBLoi
        {
            get => view_EpVien4FeederBLoi;
            set
            {
                view_EpVien4FeederBLoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region MIXER
        private string view_EpVien4MixerChay = "1";
        public string View_EpVien4MixerChay
        {
            get => view_EpVien4MixerChay;
            set
            {
                view_EpVien4MixerChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien4MixerLoi = "1";
        public string View_EpVien4MixerLoi
        {
            get => view_EpVien4MixerLoi;
            set
            {
                view_EpVien4MixerLoi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #region ĐỘNG CƠ CHÍNH
        private string view_EpVien4DongCoChinhChay = "1";
        public string View_EpVien4DongCoChinhChay
        {
            get => view_EpVien4DongCoChinhChay;
            set
            {
                view_EpVien4DongCoChinhChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien4DongCoChinh1Loi = "1";
        public string View_EpVien4DongCoChinh1Loi
        {
            get => view_EpVien4DongCoChinh1Loi;
            set
            {
                view_EpVien4DongCoChinh1Loi = value;
                RaisePropertyChanged();
            }
        }

        private string view_EpVien4DongCoChinh2Loi = "1";
        public string View_EpVien4DongCoChinh2Loi
        {
            get => view_EpVien4DongCoChinh2Loi;
            set
            {
                view_EpVien4DongCoChinh2Loi = value;
                RaisePropertyChanged();
            }
        }
        #endregion

        #endregion

        #region 5. HỆ THỐNG PHỤ TRỢ

        private string view_QuatHutBuiEpVienChay = "1";
        public string View_QuatHutBuiEpVienChay
        {
            get => view_QuatHutBuiEpVienChay;
            set
            {
                view_QuatHutBuiEpVienChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_QuatHutBuiEpVienLoi = "0";
        public string View_QuatHutBuiEpVienLoi
        {
            get => view_QuatHutBuiEpVienLoi;
            set
            {
                view_QuatHutBuiEpVienLoi = value;
                RaisePropertyChanged();
            }
        }
        
        private string view_BangTaiRaVienChay = "1";
        public string View_BangTaiRaVienChay
        {
            get => view_BangTaiRaVienChay;
            set
            {
                view_BangTaiRaVienChay = value;
                RaisePropertyChanged();
            }
        }

        private string view_BangTaiRaVienLoi = "1";
        public string View_BangTaiRaVienLoi
        {
            get => view_BangTaiRaVienLoi;
            set
            {
                view_BangTaiRaVienLoi = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region 6. ALARM

        private string view_BinChuaLieuEpVienBaoThap = "1";
        public string View_BinChuaLieuEpVienBaoThap
        {
            get => view_BinChuaLieuEpVienBaoThap;
            set
            {
                view_BinChuaLieuEpVienBaoThap = value;
                RaisePropertyChanged();
            }
        }

        private string view_BinChuaLieuEpVienBaoCao = "1";
        public string View_BinChuaLieuEpVienBaoCao
        {
            get => view_BinChuaLieuEpVienBaoCao;
            set
            {
                view_BinChuaLieuEpVienBaoCao = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}
