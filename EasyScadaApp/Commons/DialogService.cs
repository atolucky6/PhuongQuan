using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EasyScadaApp
{
    public class DialogService
    {
        public static DialogService Instance { get; } = new DialogService();

        public void Show(UserControl uc, string title = "")
        {
            DialogWindow dialog = new DialogWindow(uc, title);
            dialog.SizeToContent = SizeToContent.WidthAndHeight;
            dialog.Owner = Application.Current.MainWindow;
            dialog.ShowDialog();
        }

        public void Show(UserControl uc, Point startPoint, string title = "")
        {
            DialogWindow dialog = new DialogWindow(uc, title);
            dialog.SizeToContent = SizeToContent.WidthAndHeight;
            dialog.Owner = Application.Current.MainWindow;
            dialog.Left = startPoint.X;
            dialog.Top = startPoint.Y;
            dialog.ShowDialog();
        }
    }
}
