   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Client.PagesClient.Pages  5      !    Client.Pages.AdminPanelPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Client.Pages     5        N� Title$  AdminPanelPage��5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   6.   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��0.3* �6   6,   �� 5      6   .+�5   
   �� $��0��6   $��2��6!   $/��)Панель администратора��65   
�������$��40(�6e   $��Center=�6s   $��70, 0q�6�   �� 5   
   $��1��6   $��0��6"   .+�5      �� -   5         ��Name$ TableComboBox��5         ComboBoxStyle#���   6.   $��Center=�6V   $��30��6x   
�������$��10q�6�   .@�5      �� $��Users��6   61   �� 5      $��Tracks��6   62   �� 5      $��Albums��6   62   �� 5      $��	Playlists��6   65   �� 5      $��Genres��6   62   �� 5      $��TrackPlaylists��6   6:    � 	Resources 5      ��%�   (��       5   &   *SystemColors.WindowBrushKey+)(�� !     5    &   *" SystemColors.WindowFrameBrushKey+)��5      	Black��5      ��5       	Black��5"      5#      5$      �� 5%      -   5         ��Name$ SaveDataButton��5%        ButtonStyle#���  6-   $��35��6S   $��16(�6_   $��Сохранить��6m   $��10q�6�   �� 5&      -   5        $ DeleteDataButton��5&      #���  6/   $��35��6U   $��16(�6a   $��Удалить��6o   $��10q�6�   5'      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ 	DataTable��5(   ;     DataGridStyle#���  6   $��1��6N   $��1��6[    5*      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType	 �� Property
 �� Value)  #System.Windows.Controls.DataGridRow��%  '        7 '  �    7 �� 5+      8   "  6Q   .�5,      �� 	 � ��

 ���� 63   �� 5-      	 � ��

 �����63   �� 5.      	 � ��

 ���� 64   �� 5/      	 � ��$
 1 1 1 1q�68   �� 50      	 � ��$
 	-1,-1,0,0q�6/   �� 51      	 � ��$
 30��6/   �� 52      	 � ��$

 auto��6.   �� 53      	 � ��$
 17(�61   �� 54      	 � ��$
 Center=�6C   55      �� 56      8   "  6H   .�57      �� 	 � ��

 ���� 63   �� 58      	 � ��

 �����63   �� 59      	 � ��

 ���� 64   �� 5:      	 � ��$

 auto��6.   �� 5;      	 � ��$
 40��6/   �� 5<      	 �@��TextAlignment$

 Left=�6@   �� 5=      	 � ��$
 20(�61   �� 5>      	 � ��$
 Center=�6:   5?      5@      5A      5B      5C      