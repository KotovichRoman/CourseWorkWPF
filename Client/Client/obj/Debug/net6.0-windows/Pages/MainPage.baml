   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Client.PagesClient.Pages  5          Client.Pages.MainPage   5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Client.Pages     5        N� Title$  MainPage��5	      .��5
      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   6,   �� 5      $��0.15* �6   6-   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   .+�5   
   �� $��0��6   $��0��6!   $��Главная��61   
�������$��40(�6S   $��Center=�6a   $��70, 0q�6|   �� 5   
   $��1��6   $��0��6!   $)��#Популярные альбомы��61   
�������$��25(�6^   $��Center=�6l   $��40, 0q�6�   �� 5   
   -   5         ��Name$ 
AlbumsList��5   S      ListBoxItemContainerStyle#���   6   $��2��6g   
������ $��Center=�6�   $��Disabled=�5      ���	#00ABADB3��5      �� 5      .R�5      �� .+�5      �� $	��150��6>   $	��150��6J   ��6    �� *
AlbumImage+6J   �� 5      $��Center=�6%   $��10, 0q�6@   .+�5      ��  ��Name$ 	AlbumName��6(   
�������$��0, 10, 0, 0q�6i   $��15(�6~   ��6N   �� *	AlbumName+6~   �� 5      ���	#FF848484��6?   �� *User.UserNickname+5      5      5       ��5"      �� 5#      .R�5$      � 5%      5'      5(      5)      