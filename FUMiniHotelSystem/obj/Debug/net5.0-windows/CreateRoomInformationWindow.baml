   M S B A M L   `   `   `  ����I  EDoNgocThienWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FUMiniHotelSystemFUMiniHotelSystem  5   	   3    -FUMiniHotelSystem.CreateRoomInformationWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FUMiniHotelSystem     5   	     � Title$!  CreateRoomInformationWindow��5   	   $	��450��6-   $	��800��6:    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6   $��Room Number:��6-   �� 5   
   -   5        $��RoomNumbertxt��5   /   $��1��6   $��1��6   6/   �� 5   
   $��2��6   $��0��6   $��Room Detail Description:��6-   �� 5   
   -   5        $��RoomDetailDescriptiontxt��5   /   $��2��6   $��1��6   6/   �� 5    
   $��3��6   $��0��6   $��Room Max Capacity:��6-   �� 5!   
   -   5        $��RoomMaxCapacitytxt��5!   /   $��3��6   $��1��6   6/   �� 5#   
   $��4��6   $��0��6   $��
Room Type:��6-   �� 5$   
   -   5        $��RoomTypetxt��5$   0   $��4��6   $��1��6    60   �� 5%   
   $��5��6   $��0��6   $��Room Price Per Day:��6-   �� 5&   
   -   5        $��RoomPricePerDaytxt��5&   /   $��5��6   $��1��6   6/   �� 5(   
   -   5         ��Name$ 
AddRoombtn��5(      $��6��6%   $��0��62   $��2��6B   $��Add Room��6V   $��141,51,457,155q�6�   �� 5)   
   -   5        $��6��5)      $��1��6   $��Cancel��6.   $��290,51,167,155q�6T   5*      5+      