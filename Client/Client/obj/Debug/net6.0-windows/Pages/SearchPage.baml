   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Client.PagesClient.Pages  5          Client.Pages.SearchPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Client.Pages     5        N� Title$  
SearchPage��5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��0.3* �6   6,   �� 5      $
��0.2* �6   6,   �� 5      6   .+�5   
   �� $��0��6   $��0��6!   $��
Поиск��61   
�������$��40(�6Q   $��Center=�6_   $��70, 0q�6z   �� 5   
   -   5         ��Name$ SearchTypeBox��5   V      ComboBoxItemContainerStyle#���   6     ComboBoxStyle#���  6n   
�������$��18(�5   &   $��0��64   $��1��6A   $	��200��6Q   $��30��6]   .@�5      �� .��5      �� $��
Песни��6   5      �� 5      .��5      �� $��Альбомы��6   5      �� 5      .��5      �� $��Исполнители��6   5        � 	Resources 5!      ��%�   (��       5"   "   *SystemColors.WindowBrushKey+)(�� '     5%   "   *" SystemColors.WindowFrameBrushKey+)��5"      Transparent��5$      ��5%      Transparent��5'      5(      5)      �� 5*   
   $��0��6   $��2��6"    �� Orientation$ 
Horizontal=�62   $��Center=�6K   .+�5+      �� -   5         ��Name$ 	SearchBox��5+      $��20(�6)    �� TextWrapping$
 Wrap=�67   $	��200��6L   $��30��6X     TextBoxRadius#���  6d   6�   �� 5,      $
��Wrap=�6   $
��🔍��6,   $��30��66   $��20(�6B   
�������$��10,0,0,0q�6c   5-      �� 5.   
   -   5         ��Name$ TextChangedBlock��5.      $��1��6.   $��0��6;   $��
Песни��6K   $��20(�6X   
�������$��Center=�6y   $��Center=�6�   �� 5/   
   -   5        $ GenreBox��5/      #���  6%   $��2��6M   $��1��6]   $	��200��6j   $��30��6v    50      ��%�   (��       51   "   *SystemColors.WindowBrushKey+)(�� '     54   "   *" SystemColors.WindowFrameBrushKey+)��51      Transparent��53      ��54      Transparent��56      57      58      &   System.Windows.Controls.DataGrid  5:   
   -   5        	  Name$	 
TracksList��5:   ;     DataGridStyle#���  6   $��2��6O   $��3��6\   $y�Hidden=�6p   
   Columns
 5;      4  .System.Windows.Controls.DataGridTemplateColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 64      CellTemplate 5=      �� 5>      .R�5?      ��  ��Name$ DataGridButton��6%   $	��▶��6=   $��30��6I   $��30��6T   $��15(�6`     ButtonUndoRedoStyle#���  5@   [   
 � Tag 6%   �� *SelectedIndex+ �� ElementName$ 
TracksList��6�   5A      5C      0  *System.Windows.Controls.DataGridTextColumn  5D      $ Название��6%   $ 1* 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$ Track.TrackName�   ElementStyle 5E      �� 5F       �� 
TargetType" ��6    .�5G      ��  �� Property � �� �� Value$ Center=�6B   �� 5H       � ��$ 20, 0, 0, 0q�67   5I      5K        5L      $ 
Автор��6%   $ 1* 6e    64   �� $ Track.User.UserNickname� 5M      �� 5N      " ��6    .�5O      ��  � ��$ Center=�6B   �� 5P       � ��$ 20, 0, 0, 0q�67   5Q      5S        5T      $ Альбом��6%   $ 1* 6d    65   �� $ Track.Album.AlbumName� 5U      �� 5V      " ��6    .�5W      ��  � ��$ Center=�6B   �� 5X       � ��$ 20, 0, 0, 0q�67   5Y      5[        5\      $ Жанр��6%   $ 1* 6b    63   �� $ Track.Genre.GenreName� 5]      �� 5^      " ��6    .�5_      ��  � ��$ Center=�6B   �� 5`       � ��$ 20, 0, 0, 0q�67   5a      5c        5d      -   5        CheckColumn��$  ��5d   >   $ 30 6H    5e      �� 5f      .R�5g      �� -   5        $��Center=�5h   '     CheckBoxStyle#���  6c    d� 	IsChecked 5g   '   �� $ 	IsChecked� 6L   �� *SelectedIndex+$ 
TracksList��5h   c   5i      5k       5m      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn)  #System.Windows.Controls.DataGridRow��%  '        7 '  �    7 �� 5n      8   "  6Q   .�5o      ��  � ��
 ���� 63   �� 5p       � ��
 �����63   �� 5q       � ��
 ���� 64   �� 5r       � ��$ 1 1 1 1q�68   �� 5s       � ��$ 	-1,-1,0,0q�6/   �� 5t       � ��$ 30��6/   �� 5u       � ��$
 auto��6.   �� 5v       � ��$ 17(�61   �� 5w       � ��$ Center=�6C   5x      �� 5y      8   "  6H   .�5z      ��  � ��
 ���� 63   �� 5{       � ��
 �����63   �� 5|       � ��
 ���� 64   �� 5}       � ��$
 auto��6.   �� 5~       � ��$ 40��6/   �� 5       �@��TextAlignment$
 Left=�6@   �� 5�       � ��$ 20(�61   �� 5�       � ��$ Center=�6:   5�      5�      5�      �� 5�   
   -   5         ��Name$ 
AlbumsList��5�   S     ListBoxItemContainerStyle#���  6   $��2��6g   $��3��6t   
������ $��Center=�6�   $��Disabled=�5�   A   ���	#00ABADB3$y�Hidden=�6�   ��5�      �� 5�      .R�5�      �� .+�5�      �� $	��150��6>   $	��150��6J   ��6    �� *
AlbumImage+6J   �� 5�      $��Center=�6%   $��10, 0q�6@   .+�5�      �� $ 	AlbumName��6(   
�������$��0, 10, 0, 0q�6i   $��15(�6~   ��6N   �� *	AlbumName+6~   �� 5�      ���	#FF848484��6?   �� *User.UserNickname+5�      5�      5�      ��5�      �� 5�      .R�5�      � 5�      5�      �� 5�   
   -	   5        $ ArtistsList��5�   S   #���  6   $��2��6h   $��3��6u   
������ $��Center=�6�   $��Disabled=�5�   B   ���	#00ABADB3$y�Hidden=�6�   ��5�      �� 5�      .R�5�      �� .+�5�      �� $	��150��6=   $	��150��6I   ��6    �� *	UserImage+6I   �� 5�      $��Center=�6%   $��10, 0q�6@   .+�5�      �� $ 	AlbumName��6(   
�������$��0, 10, 0, 0q�6l   $��15(�6�   ��6N   �� *UserNickname+6�   5�      5�      5�      ��5�      �� 5�      .R�5�      � 5�      5�      5�      5�      