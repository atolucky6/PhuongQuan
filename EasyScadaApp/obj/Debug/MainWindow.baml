   M S B A M L   `   `   `  ����G  CEasyScadaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EasyScadaAppEasyScadaApp  5   	   R NEasyScada.Wpf.Connector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullbFclr-namespace:EasyScada.Wpf.Connector;assembly=EasyScada.Wpf.ConnectorEasyScada.Wpf.Connector 5   	   I EWPFUserControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:WPFUserControl;assembly=WPFUserControlWPFUserControl 5   	   7 clr-namespace:EasyScadaApp.PagesEasyScadaApp.Pages  6U       EasyScadaApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:EasyScadaApp     5   	   \	connectorFclr-namespace:EasyScada.Wpf.Connector;assembly=EasyScada.Wpf.Connector     5   	   OWPFUserControl4clr-namespace:WPFUserControl;assembly=WPFUserControl     5   	   2Pages clr-namespace:EasyScadaApp.Pages     6U   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6�     � Title$  
MainWindow��5
   	   $
��1080��6   $
��1920��6*    � WindowStyle$
 None=�67    � WindowState$ 	Maximized=�6J    � WindowStartupLocation$ CenterScreen=�6b   .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   1  +EasyScada.Wpf.Connector.EasyDriverConnector  � 5   
   $��0��6   
���   �.+�5      �� $B��<NHÀ MÁY VIÊN NÉN NĂNG LƯỢNG Ý MỸ - KCN PHÚ BÀI ��6   $��40(�5      $��Times New Roman)�6&   $
��Bold"�6C   
������$��Center=�5      $��Center=�65   5      ]� 5   
   $��1��6   ��. 
�������.+�5      (   "EasyScadaApp.Pages.ucNghienThoTinh  -   5          Name$ 	NghienTho��5   $   $y�Visible=�67   '   !EasyScadaApp.Pages.ucKhoNghienSay  5      -   5          Name$ 	KhoNghien��5   #   $y�Hidden=�66   $   EasyScadaApp.Pages.ucMayEpVien  5      -   5          Name$ 	MayEpVien��5       $y�Hidden=�63   6I   5      ]� 5   
   $��2��6   
���   ���. .+�5       �� -   5         ��Name$ btnHome��5    +   $
��Left=�6   $��8 0 0 0q�6<   $��Trang Chủ��6M   $	��130��6w   $��20(�6�   �� 5!      -   5        $ btnAlarm��5!      $
��Left=�6'   $��8 0 0 0q�6=   $��Cảnh Báo��6N   $	��120��6x   $��20(�6�   �� 5"      -   5        $ btnTrend��5"      $
��Left=�6'   $��8 0 0 0q�6=   $��Biểu Đồ��6N   $	��120��6w   $��20(�6�   �� 5#      -   5        $ btnSettings��5#      $
��Left=�6*   $��8 0 0 0q�6@   $��Cài Đặt��6Q   $	��100��6c   $��20(�6o   6}   �� 5$      -   5        $ btnReset��5$      $
��Left=�6'   $��8 0 0 0q�6=   $��Reset��6N   $	��100��6^   $��20(�6j   $
��Left=�6x   6�   �� 5%      -	   5        $ btnExit��5%   +   $
��Left=�6   $��8 0 0 0q�6<   $��Thoát��6M   $	��100��6^   $��20(�6j   6x   �� 5&      -
   5        	 ��Name$	 labThoiGian��5&   +   $��Right=�6   $��dd/MM/yyyy HH:mm:ss��5'      $��Right=�5(      $��Center=�5)      $��20(�5*      $��Times New Roman)�6"   $
��Bold"�6?   
�������6Q   5.      5/      50      