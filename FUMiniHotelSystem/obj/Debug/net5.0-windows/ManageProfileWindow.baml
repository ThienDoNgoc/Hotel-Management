   M S B A M L   `   `   `  ����I  EDoNgocThienWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FUMiniHotelSystemFUMiniHotelSystem  5   	   +    %FUMiniHotelSystem.ManageProfileWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FUMiniHotelSystem     5   	     � Title$  ManageProfileWindow��5   	   $	��409��6%   $	��422��62    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��0,0,25,4q�6   .+�5   
   �� $��Customer Full Name��6   $
��Left=�6-   $��	31,28,0,0q�6H   $	��Top=�6[   $
��Bold"�6s   �� 5   
   $��	Telephone��6   $
��Left=�6$   $��	31,74,0,0q�6?   $	��Top=�6R   $
��Bold"�6j   �� 5   
   -   5         ��Name$ CustomerFullNametxt��5      $
��Left=�6/   $��
167,36,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��194��6�   $
��Bold"�5   &   ��5      ��  �� Path$ CustomerFullName� �� Mode$ OneWay=� � DataContext 5      ��  �� ElementName$ lvCustomers��$ SelectedItem�5   &   �� 5   
   -   5        $ Telephonetxt��5      $
��Left=�6(   $��
167,82,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��194��6�   $
��Bold"�5   &   ��5      �� $ 	Telephone�$ OneWay=� 5      �� $ lvCustomers��$ SelectedItem�5   &   �� 5   
   $��Email Address��6   $
��Left=�6(   $��
31,120,0,0q�6C   $	��Top=�6W   $
��Bold"�6o   �� 5   
   $��Customer Birthday��6   $
��Left=�6,   $��
31,160,0,0q�6G   $	��Top=�6[   $
��Bold"�6s   �� 5   
   -   5        $ EmailAddresstxt��5      $
��Left=�6+   $��167,120,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��194��6�   ${�False��6�   $
��Bold"�5   &   ��5      �� $ EmailAddress�$ OneWay=� 5      �� $ lvCustomers��$ SelectedItem�5   &   �� 5   
   -   5         ��Name$ 	Updatebtn��5      $��Update��6$   $��Center=�65   $��	0,265,0,0q�6R   $	��Top=�6e   $��32��6}   $	��171��6�   $
��Bold"�5   )   $��16(�6;   �� 5   
   -   5        $ Closebtn��5      $��Close��6#   $
��Left=�63   $��
25,337,0,0q�6N   $	��Top=�6b   $��64��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��CustomerBirthdaytxt��5      $
��Left=�60   $��167,161,0,0q�6K   $	��Top=�6`   $	��194��6x   �� 5   
   $��Password��6   $
��Left=�6#   $��
31,199,0,0q�6>   $	��Top=�6R   $
��Bold"�6j   �� 5    
   -   5        $ Passwordtxt��5       $
��Left=�6'   $��167,199,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��194��6�   $
��Bold"�5"   K   ��5!      �� *EmailAddress+$ OneWay=� 5"      �� *SelectedItem+$ lvCustomers��6K   5#      5$      