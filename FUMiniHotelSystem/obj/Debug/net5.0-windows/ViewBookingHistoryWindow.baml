   M S B A M L   `   `   `  ����I  EDoNgocThienWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FUMiniHotelSystemFUMiniHotelSystem  5   	   0    *FUMiniHotelSystem.ViewBookingHistoryWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FUMiniHotelSystem     5   	     � Title$  ViewBookingHistoryWindow��5   	   $	��450��6*   $	��800��67    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��10,0,0,0q�6   .+�5   
   �� -   5         ��Name$ lvBookingReservation��5      $��0,103,400,147q�6\   $	��NaN��6s   ��5      �� 5       �� 
TargetType" ��6   .�5      -   5        5       �� View 5      �� 5      .P�5      �� $��BookingReservationId��6%    �� Width$	 120��6C    �� DisplayMemberBinding 6O   �� *BookingReservationId+�� 5      $��BookingDate��6%   $	 100��6:    6F   �� *BookingDate+�� 5      $��
TotalPrice��6%   $	 100��69    6E   �� *
TotalPrice+�� 5      $��Customer Email Address��6%   $	 150��6E    6Q   �� *Customer.EmailAddress+5      5      �� 5   
   -   5        $ lvBookingDetails��5      $��395,103,5,147q�6X   $	��NaN��6o    5      �� 5      .P�5      �� $��Room Id��6%   $	 100��66    6B   �� *RoomId+�� 5       $��
Start Date��6%   $	 100��69    6E   �� *	StartDate+�� 5!      $��End Date��6%   $	 100��67    6C   �� *	EndDate+�� 5"      $��Actual Price��6%   $	 100��6;    6G   �� *ActualPrice+5#      5%      �� 5(   
   -   5         ��Name$ Closebtn��5(      $��Close��6#   $
��Left=�63   $��
27,365,0,0q�6N   $	��Top=�6b   $��64��6�   �� 5)   
   $��Booking Detail:��6   $
��Left=�6*   $��
400,65,0,0q�6E   $	��Top=�6Y   $	��100��6q   $
��Bold"�6}   �� 5*   
   $��Booking Reservation:��6   $
��Left=�6/   $��	10,65,0,0q�6J   $	��Top=�6]   $	��141��6u   $
��Bold"�6�   �� 5+   
   $��BOOKING HISTORY��6   $��Center=�6*   $��0,10,0,0q�6G   $	��Top=�6Y   $	��210��6q   $��38��6}   $��Center=�6�   $��20(�6�   $
��Bold"�6�   ���	#FFED19196�   5-      5.      