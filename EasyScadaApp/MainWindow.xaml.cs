using System.Threading;
using System.Windows;

namespace EasyScadaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Nút nhấn footer
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            NghienTho.Visibility = Visibility.Hidden;
            KhoNghien.Visibility = Visibility.Visible;
            MayEpVien.Visibility = Visibility.Hidden;
        }

        private void BtnAlarm_Click(object sender, RoutedEventArgs e)
        {
            NghienTho.Visibility = Visibility.Visible;
            KhoNghien.Visibility = Visibility.Hidden;
            MayEpVien.Visibility = Visibility.Hidden;
        }

        private void BtnTrend_Click(object sender, RoutedEventArgs e)
        {
            //NghienTho.labNhietGoiBi1MayNghienTho1.Content = "1000 oC";
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            NghienTho.Visibility = Visibility.Hidden;
            KhoNghien.Visibility = Visibility.Hidden;
            MayEpVien.Visibility = Visibility.Visible;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
