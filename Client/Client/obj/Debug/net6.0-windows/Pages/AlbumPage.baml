   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Client.PagesClient.Pages  5          Client.Pages.AlbumPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Client.Pages     5        N� Title$  	AlbumPage��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   6,   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      6!   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   .+�5      �� -   5         ��Name$ 
AlbumImage��5      $	��100��6(   $	��100��64   $��10, 0, 0, 0q�6A   6X   �� 5      $��Center=�6   $��10, 0q�64   .+�5      �� $��Альбом��6   
�������$��15(�6=   $��	0, 0, 0 2q�6K   6`   �� 5      -   5         ��Name$ 	AlbumName��5      
�������$��30(�6B   $��	0, 0, 0 2q�6P   6e   �� 5      -   5        $ UserName��5      ���	#FF848484$��20(�6E   6U   5      5      �� 5   
   -   5         ��Name$ ChangeAlbumButton��5         ButtonStyle#���   6,   $��Изменить��6R   $	��150��6e   $��30��6q   $��Right=�5      $��50, 0q�6-   $��18(�6<   $y�Hidden=�6J   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
TracksList��5   ;     DataGridStyle#���  6   $��1��6O      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 #��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 50 64      CellTemplate 5      �� 5       .R�5!      �� $ DataGridButton��6%   -   5        $	��▶��5!   =   $��30��6I   $��30��6T   $��15(�6`     ButtonUndoRedoStyle#���  5"   [   
 � Tag 6%   �� *SelectedIndex+ �� ElementName$ 
TracksList��6�   5#      5%      0  *System.Windows.Controls.DataGridTextColumn  5&      $	 Название��6%   $
 1* 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ��  �� Path$ Track.TrackName�   ElementStyle 5'      �� 5(       �� 
TargetType" ��6    .�5)      ��  �� Property � �� �� Value$ Center=�6B   �� 5*       � ��$ 20, 0, 0, 0q�67   5+      5-        5.      $	 
Автор��6%   $
 1* 6e    64   �� $ Track.User.UserNickname� 5/      �� 50      " ��6    .�51      ��  � ��$ Center=�6B   �� 52       � ��$ 20, 0, 0, 0q�67   53      55        56      $	 Альбом��6%   $
 1* 6d    65   �� $ Track.Album.AlbumName� 57      �� 58      " ��6    .�59      ��  � ��$ Center=�6B   �� 5:       � ��$ 20, 0, 0, 0q�67   5;      5=        5>      $	 Жанр��6%   $
 1* 6b    63   �� $ Track.Genre.GenreName� 5?      �� 5@      " ��6    .�5A      ��  � ��$ Center=�6B   �� 5B       � ��$ 20, 0, 0, 0q�67   5C      5E        5F      -   5        CheckColumn��$	  ��5F   >   $
 30 6H    5G      �� 5H      .R�5I      �� -   5        $��Center=�5J   '     CheckBoxStyle#���  6c    d� 	IsChecked 5I   '   �� $ 	IsChecked� 6L   �� *SelectedIndex+$ 
TracksList��5J   c   5K      5M       � 	Resources 5O      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn)  #System.Windows.Controls.DataGridRow��%  '        7 '  �    7 �� 5P      8   "  6Q   .�5Q      ��  � ��
 ���� 63   �� 5R       � ��
 �����63   �� 5S       � ��
 ���� 64   �� 5T       � ��$ 1 1 1 1q�68   �� 5U       � ��$ 	-1,-1,0,0q�6/   �� 5V       � ��$ 30��6/   �� 5W       � ��$
 auto��6.   �� 5X       � ��$ 17(�61   �� 5Y       � ��$ Center=�6C   5Z      �� 5[      8   "  6H   .�5\      ��  � ��
 ���� 63   �� 5]       � ��
 �����63   �� 5^       � ��
 ���� 64   �� 5_       � ��$
 auto��6.   �� 5`       � ��$ 40��6/   �� 5a       �@��TextAlignment$
 Left=�6@   �� 5b       � ��$ 20(�61   �� 5c       � ��$ Center=�6:   5d      5e         	CellStyle 5f      �� 5g      *	  $System.Windows.Controls.DataGridCell" 	 6   .�5h      ��  � ��
 ���� 63    �� Triggers 5i      �� 5j       �� Binding 6&   �� *Check+ �� Value true6@   .a�5k      ��  � ��
 �����6;   5l      5n      5p      5r      5s      