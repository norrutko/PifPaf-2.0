   M S B A M L   `   `   `  ����E  AStrzelnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Strzelnica
Strzelnica  5   	       Strzelnica.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Strzelnica     5   	     � Title$  PIF-PAF 2.0��5   	   $	��480��6   $	��640��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��3* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   $��2��6!   $��Center=�62   $��Right=�6M   .��6i   Zawody6q   �� 5   
   -   5        $
��Mode��5       � Maximum$ 1Q�6    �� TickFrequency$ 1Q�6)   $��1��6;   $��2��6K   $��Center=�6\   $��1.4,37,97,37.4q�5   2   $��2��6J    �� IsSnapToTickEnabled . 6^   �� 5   
   $��2��6   $��2��6!   $��Center=�62   $
��Left=�6M   .��6h   Liga6n   �� 5    
   -   5        $��
StringMode��5       $��Zawody��6'   $��3��65   $��0��6E   $��Center=�6R   $��Center=�5!      �� 5"   
   -   5        $��StringWeapon��5"      $��Pistolet��6(   $��3��68   $��1��6H   $��Center=�6U   $��Center=�5#      �� 5$   
   $��4��6   $��2��6!   $��Center=�62   $��Right=�6M   .��6i   
Pistolet6s   �� 5%   
   -   5        $��Weapon��5%      $ 1Q�6   $ 1Q�6+   $��5��6=   $��2��6M   $��Center=�6^    . 5'      �� 5(   
   $��6��6   $��2��6"   $��Center=�63   $
��Left=�6N   .��6i   	Karabin6r   �� 5)   
   -   5        $��Scores��5)      $��2��6   $��7��6,   $��20q�6@   $��Stretch=�6L   $��Stretch=�5*      .��6B   Wyniki6J   �� 5+   
   -   5        $��	AddScores��5+      $��3��6"   $��7��6/   $��20q�6C   $��Stretch=�6O   $��Stretch=�5,      .��6E   Dodaj wynik6R   �� 5-   
   -   5        $��	AddPerson��5-      $��4��6"   $��7��6/   $��20q�6C   $��Stretch=�6O   $��Stretch=�5.      .��6E   Dodaj/Usuń osobę6W   �� 5/   
   -   5        $��
FindPerson��5/      $��5��6#   $��7��60   $��20q�6D   $��Stretch=�6P   $��Stretch=�50      .��6F   Wyszukaj osobę6V   51      52      