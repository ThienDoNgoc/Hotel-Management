   M S B A M L   `   `   `  ����I  EDoNgocThienWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FUMiniHotelSystemFUMiniHotelSystem  5   	   ,    &FUMiniHotelSystem.UpdateCustomerWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FUMiniHotelSystem     5   	     � Title$  UpdateCustomerWindow��5   	   $	��450��6&   $	��800��63    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��10,10,10,-53q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��Customer Full Name:��6-   �� 5   
   -   5         ��Name$ CustomerFullNametxt��5   /   $��0��6   $��1��6   6/   �� 5   
   $��1��6   $��0��6   $��
Telephone:��6-   �� 5   
   -   5        $ Telephonetxt��5   /   $��1��6   $��1��6   6/   �� 5   
   $��2��6   $��0��6   $��Email Address:��6-   �� 5    
   -   5        $ EmailAddresstxt��5    /   $��2��6   $��1��6   ${�False��6H   $
��Bold"�6Z   �� 5"   
   $��3��6   $��0��6   $��Customer Birthday:��6-   (  "System.Windows.Controls.DatePicker  5#   
   -   5        $��CustomerBirthdaytxt��5#      $��3��60   $��1��6=   $��
0,0,506,26q�6M   $��2��6a   �� 5%   
   $��4��6   $��0��6   $��	Password:��6-   �� 5&   
   -   5        $ Passwordtxt��5&   /   $��4��6   $��1��6   6/   �� 5(   
   -   5         ��Name$ UpdateCustomerbtn��5(      $��6��6,   $��1��69   $��Update Customer��6I   $��38,27,459,199q�6�   �� 5)   
   -   5        $��6��5)      $��1��6   $��Cancel��6.   $��321,27,176,199q�6T   5*      5+      