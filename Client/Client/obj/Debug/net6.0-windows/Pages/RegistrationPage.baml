   M S B A M L   `   `   `  ����A  =Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Client.PagesClient.Pages  5      #    Client.Pages.RegistrationPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Client.Pages     5        N� Title$  LogIn��5	       N� 
Foreground
 �����.��5
      � .+�5   
   �� $
��Wrap=�6   $��Регистрация��6(   $��Center=�6;   $	��Top=�6X   $��60��6p   $��40(�6|   $��10q�6�   $��Light"�6�   �� 5   
   $��Center=�6   .+�5      �� $
��Wrap=�6   $��
Логин��6,   $��18(�69   $��25, 15, 0, 5q�6G   $��Light"�6]   �� 5      -   5         ��Name$ LoginBox��5         TextBoxRadius#���   6(    �� TextWrapping$
 Wrap=�6P   $	��350��6d   $��25��6p   $��16(�6|   $��Light"�6�    �� 	MaxLength$ 40��6�   �� 5      $
��Wrap=�6   $%��Имя пользователя��6,   $��18(�6D   $��25, 15, 0, 5q�6R   $��Light"�6h   �� 5      -   5        $ NicknameBox��5      #���   6+   $
 Wrap=�6S   $	��350��6g   $��25��6s   $��16(�6   $��Light"�6�   $ 40��6�   �� 5      $
��Wrap=�6   $��Пароль��6,   $��18(�6:   $��25, 15, 0, 5q�6H   $��Light"�6^   G� 5      -   5         G�Name$ PasswordBox��5   E     PasswordBoxStyle#���  6   $	��350��6[   $��25��6g   $��16(�6s   $��Light"�6�    G� 	MaxLength$ 40��6�   �� 5      $
��Wrap=�6   $-��'Подтверждение пароля��6,   $��18(�6H   $��25, 15, 0, 5q�6V   $��Light"�6l   G� 5      -   5        $ AcceptPasswordBox��5      #���  65   $	��350��6a   $��25��6m   $��16(�6y   $��Light"�6�   $ 40��6�   5      5      5      