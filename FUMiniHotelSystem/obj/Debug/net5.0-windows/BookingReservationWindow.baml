   M S B A M L   `   `   `  ����I  EDoNgocThienWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FUMiniHotelSystemFUMiniHotelSystem  5   	   0    *FUMiniHotelSystem.BookingReservationWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FUMiniHotelSystem     5   	     � Title$  BookingReservationWindow��5   	   $	��450��6*   $	��800��67    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �� $��Booking Reservation Id��6   $
��Left=�61   $��	37,30,0,0q�6L   $	��Top=�6_   �� 5   
   $��Booking Date��6   $
��Left=�6'   $��	37,74,0,0q�6B   $	��Top=�6U   �� 5   
   $��Total Price��6   $
��Left=�6&   $��
37,116,0,0q�6A   $	��Top=�6U   �� 5   
   -   5         ��Name$ BookingReservationIdtxt��5      $
��Left=�63   $��
181,38,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��194��6�   ${�False��6�   $
��Bold"�5   T   ��5      �� *BookingReservationId+ �� Mode$ OneWay=� � DataContext 5      �� *SelectedItem+ �� ElementName$ lvBookingReservation��6T   �� 5   
   -   5        $ BookingDatetxt��5      $
��Left=�6*   $��
181,82,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��194��6�   ${�False��6�   $
��Bold"�5   T   ��5      �� *BookingDate+$ OneWay=� 5      �� *SelectedItem+$ lvBookingReservation��6T   �� 5   
   -   5        $ TotalPricetxt��5      $
��Left=�6)   $��181,124,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��194��6�   ${�False��6�   $
��Bold"�5   T   ��5      �� *
TotalPrice+$ OneWay=� 5      �� *SelectedItem+$ lvBookingReservation��6T   �� 5   
   $��Customer Email Address��6   $
��Left=�61   $��
35,158,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ CustomerEmailAddresstxt��5      $
��Left=�63   $��181,166,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��194��6�   ${�False��6�   $
��Bold"�5   T   ��5      �� *Customer.EmailAddress+$ OneWay=� 5      �� *SelectedItem+$ lvBookingReservation��6T   �� 5   
   -   5         ��Name$ 	Deletebtn��5      $��Delete��6$   $
��Left=�65   $��319,217,0,0q�6P   $	��Top=�6e   $��32��6}   $��56��6�   5      �� 5   
   -   5        $ 	Insertbtn��5      $��New Booking��6$   $
��Left=�6:   $��
27,217,0,0q�6U   $	��Top=�6i   $��32��6�   $	��118��6�   5      �� 5   
   -   5         ��Name$ lvBookingReservation��5      $��400,0,0,250q�6\   $	��NaN��6q   ��5       �� 5!      	 �� 
TargetType"	 ��6   .�5"      -   5        5#      
 �� View
 5%      �� 5&      .P�5'      �� $��BookingReservationId��6%    �� Width$	 120��6C    �� DisplayMemberBinding 6O   �� *BookingReservationId+�� 5(      $��BookingDate��6%   $	 100��6:    6F   �� *BookingDate+�� 5)      $��
TotalPrice��6%   $	 100��69    6E   �� *
TotalPrice+�� 5*      $��Customer Email Address��6%   $	 150��6E    6Q   �� *Customer.EmailAddress+5+      5.      �� 50   
   -	   5        $ lvBookingDetails��50      $��400,228,0,49q�6X   $	��NaN��6n   
 51      �� 52      .P�53      �� $��Room Id��6%   $	 100��66    6B   �� *RoomId+�� 54      $��
Start Date��6%   $	 100��69    6E   �� *	StartDate+�� 55      $��End Date��6%   $	 100��67    6C   �� *	EndDate+�� 56      $��Actual Price��6%   $	 100��6;    6G   �� *ActualPrice+57      59      �� 5<   
   -
   5        $ Closebtn��5<      $��Close��6#   $
��Left=�63   $��
27,365,0,0q�6N   $	��Top=�6b   $��64��6�   �� 5=   
   $��Booking Detail:��6   $
��Left=�6*   $��400,199,0,0q�6E   $	��Top=�6Z   $��99��6r   $
��Bold"�6}   5?      5@      