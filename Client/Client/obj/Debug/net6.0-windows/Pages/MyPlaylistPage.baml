   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Client.PagesClient.Pages  5      !    Client.Pages.MyPlaylistPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Client.Pages     5        N� Title$  MyPlaylistPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   6,   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      6!   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   .+�5      �� -   5         ��Name$ 
AlbumImage��5      $	��100��6(   $	��100��64   $��10, 0, 0, 0q�6A   6X   �� 5      $��Center=�6   $��10, 0q�64   .+�5      �� $��Мой плейлист��6   
�������$��30(�6D   $��	0, 0, 0 2q�6R   6g   �� 5      -   5         ��Name$ UserName��5      ���	#FF848484$��20(�6E   6U   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
TracksList��5   ;      DataGridStyle#���   6   $��1��6O      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 50 64   
   CellTemplate
 5      �� 5      .R�5      ��  ��Name$ DataGridButton��6%   -   5        $	��▶��5   =   $��30��6I   $��30��6T   $��15(�6`     ButtonUndoRedoStyle#���  5    [   
 � Tag 6%   �� *SelectedIndex+ �� ElementName$ 
TracksList��6�   5!      5#      0  *System.Windows.Controls.DataGridTextColumn  5$      $ Название��6%   $	 1* 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$ Track.TrackName�   ElementStyle 5%      �� 5&       �� 
TargetType" ��6    .�5'      ��  �� Property � �� �� Value$ Center=�6B   �� 5(       � ��$ 20, 0, 0, 0q�67   5)      5+        5,      $ 
Автор��6%   $	 1* 6e    64   �� $ Track.User.UserNickname� 5-      �� 5.      " ��6    .�5/      ��  � ��$ Center=�6B   �� 50       � ��$ 20, 0, 0, 0q�67   51      53        54      $ Альбом��6%   $	 1* 6d    65   �� $ Track.Album.AlbumName� 55      �� 56      " ��6    .�57      ��  � ��$ Center=�6B   �� 58       � ��$ 20, 0, 0, 0q�67   59      5;        5<      $ Жанр��6%   $	 1* 6b    63   �� $ Track.Genre.GenreName� 5=      �� 5>      " ��6    .�5?      ��  � ��$ Center=�6B   �� 5@       � ��$ 20, 0, 0, 0q�67   5A      5C        5D      -   5        CheckColumn��$  ��5D   >   $	 30 6H   
 5E      �� 5F      .R�5G      �� -   5        $��Center=�5H   '     CheckBoxStyle#���  6c    d� 	IsChecked 5G   '   �� $ 	IsChecked� 6L   �� *SelectedIndex+$ 
TracksList��5H   c   5I      5K       � 	Resources 5M      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn)  #System.Windows.Controls.DataGridRow��%  '        7 '  �    7 �� 5N      8   "  6Q   .�5O      ��  � ��
 ���� 63   �� 5P       � ��
 �����63   �� 5Q       � ��
 ���� 64   �� 5R       � ��$ 1 1 1 1q�68   �� 5S       � ��$ 	-1,-1,0,0q�6/   �� 5T       � ��$ 30��6/   �� 5U       � ��$
 auto��6.   �� 5V       � ��$ 17(�61   �� 5W       � ��$ Center=�6C   5X      �� 5Y      8   "  6H   .�5Z      ��  � ��
 ���� 63   �� 5[       � ��
 �����63   �� 5\       � ��
 ���� 64   �� 5]       � ��$
 auto��6.   �� 5^       � ��$ 40��6/   �� 5_       �@��TextAlignment$
 Left=�6@   �� 5`       � ��$ 20(�61   �� 5a       � ��$ Center=�6:   5b      5c      5d      5e      5f      