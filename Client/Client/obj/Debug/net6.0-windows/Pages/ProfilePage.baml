   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Client.PagesClient.Pages  5          Client.Pages.ProfilePage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Client.Pages     5        N� Title$  ProfilePage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��0.3* �6   6,   �� 5      $
��0.1* �6   6,   �� 5      6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   .+�5      �� -   5         ��Name$ 	UserImage��5      $��80��6'   $��80��62   $��10, 0, 0, 0q�6>   6U   �� 5      $��Center=�6   $��10, 0q�64   .+�5      �� -   5         ��Name$ 	UserLogin��5      
�������$��15(�6C   $��	0, 0, 0 2q�6Q   �� 5      -   5        $ UserNickname��5      
�������$��30(�6E   $��	0, 0, 0 2q�6S   6h   5      5      �� 5   
   -   5         ��Name$ SettingsButton��5      $��0��6      ButtonStyle#���   66   $��Right=�6\   $	��200��5      $��35��6   $1��+Редактирование профиля��6)   $��16(�6J   $��30, 0q�6u   �� 5   
   $��1��6   $��Альбомы��6!   
�������$��18(�6C   $��Center=�6Q   $��30, 0q�6l   �� 5   
   -   5        $ AddAlbumButton��5      $��1��6)   $#��Добавить альбом��66   $��16(�6P   #���   6^   $	��200��6�   $��35��5      $��Right=�6   $��0, 0, 30, 0q�69   6N   �� 5    
   -   5         ��Name$ 
AlbumsList��5         ListBoxItemContainerStyle#���  6&   $��2��6g   
������ $��Center=�6�   $��Disabled=�5!      ���	#00ABADB3��5"      �� 5#      .R�5$      �� .+�5%      �� $	��150��6>   $	��150��6J   ��6    �� *
AlbumImage+6J   �� 5&      $��Center=�6%   $��10, 0q�6@   .+�5'      �� $ 	AlbumName��6(   
�������$��0, 10, 0, 0q�6i   $��15(�6~   ��6N   �� *	AlbumName+6~   5(      5)      5*      ��5,      �� 5-      .R�5.      � 5/      51      52      53      