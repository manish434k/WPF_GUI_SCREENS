   M S B A M L   `   `   `  ����  npeimanovic_Client&     npeimanovic_Client.DataBaseSetUp   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� Source�� 5   
   $  ApplicationDictionary.xaml?�6   %    .��5
      �  � RowDefinitions 5   
   �� 5      $	��142 �6   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   � $��1��6    5      �� 5      $��36 �6    �� 5      $��1* �6    .+�5      � $	��Top=�6   $
��auto��6+   $��36��68      StandardSolidColorBrush#��[  6D   .+�5      �� $?��9Local Network (only shows when local network is selected)��6   $��Center=�6\   $��18(�6y   $
��Bold"�6�     TextHeaderColor#��[ 6�   $��127,0q�6�   $��2��6�   5      �� 5      $��1��6   $��20q�6'    �� Orientation$ 
Horizontal=�63   $��36��6L   .+�5      � .+�5      �� -   5        $	��400��5   :   $'��!Select Database Network Location ��6F     TextBoxStyle1#��[ 6o   �� 5      $��Images\open.png��6   $��Right=�66   $��2q�6R   5      � 5      $
��20,0q�6   .+�5"      ��   ButtonTemplate1#��[ 6   .��5#      �� $ 
Horizontal=�6%   .+�5$      �� $��Images\testconnection.png��6$   $
��Left=�6H   �� 5%      $��Test Connection��6(   $��10q�6?   6M   5&      5'      5)      5*      5+      � 5,   
   $��2��6    5-      �� 5.      $��36 �6    �� 5/      $��1* �6    �� 50      $��3* �6    .+�52      � $	��Top=�6   $
��auto��6,   $��36��69   #��[  6E   .+�54      �� $>��8AWS Database (only shows when AWS database is selected) ��6   $��Center=�6[   $��18(�6x   $
��Bold"�6�   #��[ 6�   55      �� 56      $��1��6   $��	20,20,0,0q�6'   $ 
Horizontal=�6:   $��36��6S   $	��Top=�6_   .+�57      � .+�58      �� -   5        $��
 Host Name��58   ;   $	��400��6M   #��[ 6Y   5:      � 5;      $
��20,0q�6   .+�5=      �� #��[ 6   .��5>      �� $ 
Horizontal=�6%   .+�5?      �� $��Images\testconnection.png��6$   �� 5@      $��Test Connection��6(   $��10q�6?   6M   5A      5B      5D      5E      � 5F      $��2��6   $	��200��6    $��36��6,   $
��Left=�68   $	��Top=�6S   $��20,0 q�6k   .+�5G      �� -   5        $�� Port Number��5G   7   $	��200��6K   #��[ 6W   5I      5J      5K      5L      