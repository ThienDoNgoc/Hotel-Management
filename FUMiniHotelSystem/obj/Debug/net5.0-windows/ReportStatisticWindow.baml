   M S B A M L   `   `   `  ����I  EDoNgocThienWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FUMiniHotelSystemFUMiniHotelSystem  5   	   -    'FUMiniHotelSystem.ReportStatisticWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FUMiniHotelSystem     5   	     � Title$  ReportStatisticWindow��5   	   $	��450��6'   $	��800��64    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � .+�5   
   (  "System.Windows.Controls.DatePicker  -   5        $��StartDatePicker��5      $
��Left=�6,   $��	10,26,0,0q�6G   $	��Top=�6Z   $	��100��6r     5   
   -   5        $��EndDatePicker��5      $
��Left=�6*   $��	10,68,0,0q�6E   $	��Top=�6X   $	��100��6p   �� 5   
   -   5         ��Name$ lvRoomInformation��5      $��186,0,0,141q�6Y   $	��NaN��6n    �� View 5      �� 5      .P�5      �� $��BookingReservationId��6%    �� Width$	 150��6C    �� DisplayMemberBinding 6O   �� *BookingReservationId+�� 5      $��RoomId��6%   $ 80��65    6@   �� *RoomId+�� 5      $��	StartDate��6%   $	 100��68    6D   �� *	StartDate+�� 5      $��EndDate��6%   $	 100��66    6B   �� *	EndDate+�� 5      $��ActualPrice��6%   $	 100��6:    6F   �� *ActualPrice+�� 5      $��Customer ID��6%   $ 80��6:    6E   �� *BookingReservation.CustomerId+5      5      �� 5   
   -   5        $��LoadData��5      $��	Load Data��68   $
��Left=�6L   $��
10,110,0,0q�6g   $	��Top=�6{   $	��100��6�   �� 5   
   -   5         ��Name$ Closebtn��5      $��Close��6#   $
��Left=�63   $��
25,381,0,0q�6N   $	��Top=�6b   $��21��6z   $��70��6�   6�   �� 5   
   $ ��Number of booking details:��6   $
��Left=�65   $��186,314,0,0q�6P   $	��Top=�6e   �� 5   
   -   5         ��Name$ NumberOfBookinglbs��5      $
��Left=�6,   $��346,314,0,0q�6G   $	��Top=�6\    J� RenderTransformOrigin$ 0.933,0.671&�6t   $��90��6�   �� 5   
   $��Total Price:��6   $
��Left=�6'   $��493,314,0,0q�6B   $	��Top=�6W   �� 5   
   -   5        $ TotalPricelbs��5      $
��Left=�6'   $��565,314,0,0q�6B   $	��Top=�6W   $ 0.933,0.671&�6o   $��90��6�   5      5       