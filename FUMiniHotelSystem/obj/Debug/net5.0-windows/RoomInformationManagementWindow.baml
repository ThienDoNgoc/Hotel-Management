   M S B A M L   `   `   `  ����I  EDoNgocThienWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FUMiniHotelSystemFUMiniHotelSystem  5   	   7    1FUMiniHotelSystem.RoomInformationManagementWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FUMiniHotelSystem     5   	     � Title$%  RoomInformationManagementWindow��5   	   $	��464��61   $	��800��6>    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $	��434��6   $	��Top=�6   .+�5   
   �� $��RoomId��6   $
��Left=�6!   $��	37,47,0,0q�6<   $	��Top=�6O   �� 5   
   $��Room Number��6   $
��Left=�6&   $��	37,91,0,0q�6A   $	��Top=�6T   �� 5   
   $��Room Detail Description��6   $
��Left=�62   $��
37,133,0,0q�6M   $	��Top=�6a   �� 5   
   -   5         ��Name$ 	RoomIdtxt��5      $
��Left=�6%   $��
181,55,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��194��6�   ${�False��6�   $
��Bold"�5   Q   ��5      �� *RoomId+ �� Mode$ OneWay=� � DataContext 5      �� *SelectedItem+ �� ElementName$ lvRoomInformation��6Q   �� 5   
   -   5        $ RoomNumbertxt��5      $
��Left=�6)   $��
181,99,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��194��6�   ${�False��6�   $
��Bold"�5   Q   ��5      �� *
RoomNumber+$ OneWay=� 5      �� *SelectedItem+$ lvRoomInformation��6Q   �� 5   
   -   5        $ RoomDetailDescriptiontxt��5      $
��Left=�64   $��181,141,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��194��6�   ${�False��6�   $��52��5   Q   $
��Bold"�6]   ��5      �� *RoomDetailDescription+$ OneWay=� 5      �� *SelectedItem+$ lvRoomInformation��6]   �� 5   
   $��Room Max Capacity��6   $
��Left=�6,   $��35,0,0,0q�6G   $��Center=�6Y   �� 5   
   $��Room Price Per Day��6   $
��Left=�6-   $��
37,241,0,0q�6H   $	��Top=�6\   �� 5   
   -   5        $ RoomMaxCapacitytxt��5      $
��Left=�6.   $��181,212,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��194��6�   ${�False��6�   $
��Bold"�5   Q   ��5      �� *RoomMaxCapacity+$ OneWay=� 5      �� *SelectedItem+$ lvRoomInformation��6Q   �� 5   
   -   5        $ RoomPricePerDaytxt��5      $
��Left=�6.   $��181,249,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��194��6�   ${�False��6�   $
��Bold"�5   Q   ��5      �� *RoomPricePerDay+$ OneWay=� 5      �� *SelectedItem+$ lvRoomInformation��6Q   �� 5   
   -   5         ��Name$ 	Updatebtn��5      $��Update��6$   $
��Left=�65   $��232,318,0,0q�6P   $	��Top=�6e   $��32��6}   $��56��6�   5       �� 5!   
   -   5        $ 	Deletebtn��5!      $��Delete��6$   $
��Left=�65   $��319,318,0,0q�6P   $	��Top=�6e   $��32��6}   $��56��6�   5"      �� 5#   
   -   5        $ 	Insertbtn��5#      $��Insert new room��6$   $
��Left=�6>   $��
37,318,0,0q�6Y   $	��Top=�6m   $��32��6�   $	��118��6�   5$      �� 5%   
   -	   5         ��Name$ lvRoomInformation��5%      $��
400,0,0,17q�6Y   $	��NaN��6m   	 �� View	 5&      �� 5'      .P�5(      �� $��Room ID��6%   
 �� Width$	
 100��66    �� DisplayMemberBinding 6B   �� *RoomId+�� 5)      $��Room Number��6%   $	
 100��6:    6F   �� *
RoomNumber+�� 5*      $��Room Detail Description��6%   $	
 150��6F    6R   �� *RoomDetailDescription+�� 5+      $��Room Max Capacity��6%   $	
 150��6@    6L   �� *RoomMaxCapacity+�� 5,      $��Room Price Per Day��6%   $	
 150��6A    6M   �� *RoomPricePerDay+�� 5-      $��	Room Type��6%   $	
 100��68    6D   �� *RoomType.RoomTypeName+5.      50      �� 51   
   -
   5        $ Closebtn��51      $��Close��6#   $
��Left=�63   $��
17,379,0,0q�6N   $	��Top=�6b   $��64��6�   �� 52   
   $��	Room Type��6   $
��Left=�6$   $��
37,275,0,0q�6?   $	��Top=�6S   �� 53   
   -   5        $ RoomTypetxt��53      $
��Left=�6'   $��181,284,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��194��6�   ${�False��6�   $
��Bold"�55   Q   ��54      �� *RoomType.RoomTypeName+$ OneWay=� 55      �� *SelectedItem+$ lvRoomInformation��6Q   �� 56   
   -   5        $ 	SearchBtn��56      $��Search��6$   $
��Left=�65   $��265,0,0,394q�6P   $��Bottom=�6e   6�   �� 57   
   -   5        $ 
keyWordtxt��57      $
��Left=�6&   $��
114,20,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $	��146��6�   $��20��6�   59      5:      