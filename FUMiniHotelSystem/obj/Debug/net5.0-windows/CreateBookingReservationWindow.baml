   M S B A M L   `   `   `  ����I  EDoNgocThienWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FUMiniHotelSystemFUMiniHotelSystem  5   	   6    0FUMiniHotelSystem.CreateBookingReservationWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FUMiniHotelSystem     5   	     � Title$$  CreateBookingReservationWindow��5   	   $	��450��60   $	��800��6=    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   �� $��End Date��6   $
��Left=�6#   $��
39,148,0,0q�6>   $	��Top=�6R   �� 5   
   $��Customer Email Address��6   $
��Left=�61   $��	37,22,0,0q�6L   $	��Top=�6_   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��StartDatePicker��5      $
��Left=�6,   $��183,111,0,0q�6G   $	��Top=�6\   $	��100��6t     5   
   -   5        $��EndDatePicker��5      $
��Left=�6*   $��183,148,0,0q�6E   $	��Top=�6Z   $	��100��6r   �� 5   
   -   5         ��Name$ 
BookingBtn��5      $��Booking��6%   $
��Left=�67   $��717,286,0,0q�6R   $	��Top=�6g   $��32��6   $��56��6�   5      �� 5   
   -   5        $ 	Insertbtn��5      $	��Add��6$   $
��Left=�62   $��
37,195,0,0q�6M   $	��Top=�6a   $��32��6y   $	��118��6�   5      �� 5   
   -   5         ��Name$ lvBookingDetails��5      $��400,2,0,218q�6X   $	��NaN��6m    �� View 5      �� 5      .P�5      �� $��Room Id��6%    �� Width$ 70��66    �� DisplayMemberBinding 6A   �� *RoomId+�� 5      $��
Start Date��6%   $	 100��69    6E   �� *	StartDate+�� 5      $��End Date��6%   $	 100��67    6C   �� *	EndDate+�� 5      $��Actual Price��6%   $	 100��6;    6G   �� *ActualPrice+5      5      �� 5   
   -   5        $ Closebtn��5      $��Close��6#   $
��Left=�63   $��
27,365,0,0q�6N   $	��Top=�6b   $��64��6�   �� 5    
   $��Total Price:��6   $
��Left=�6'   $��400,237,0,0q�6B   $	��Top=�6W   $��75��6o   $
��Bold"�6z   �� 5!   
   -   5         ��Name$ TotalPricelb��5!      $
��Left=�6&   $��480,237,0,0q�6A   $	��Top=�6V   $	��100��6n   $
��Bold"�6z   �� 5"   
   -   5         ��Name$ CustomerEmailcb��5"      $
��Left=�6,   $��
183,24,0,0q�6G   $	��Top=�6[   $	��194��6s   �� 5#   
   $��Room Id��6   $
��Left=�6"   $��	37,67,0,0q�6=   $	��Top=�6P   �� 5$   
   -	   5        $ RoomIdcb��5$      $
��Left=�6%   $��
183,69,0,0q�6@   $	��Top=�6T   $	��194��6l   �� 5%   
   $��
Start Date��6   $
��Left=�6%   $��
39,109,0,0q�6@   $	��Top=�6T   5'      5(      