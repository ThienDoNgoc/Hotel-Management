   M S B A M L   `   `   `  ����I  EDoNgocThienWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FUMiniHotelSystemFUMiniHotelSystem  5   	   0    *FUMiniHotelSystem.CustomerManagementWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:FUMiniHotelSystem     5   	     � Title$  CustomerManagementWindow��5   	   $	��437��6*   $	��800��67    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      � $��0,0,0,-6q�6   .+�5   
   �� $��
CustomerId��6   $
��Left=�6%   $��	37,56,0,0q�6@   $	��Top=�6S   �� 5   
   $��Customer Full Name��6   $
��Left=�6-   $��
37,100,0,0q�6H   $	��Top=�6\   �� 5   
   $��	Telephone��6   $
��Left=�6$   $��
37,146,0,0q�6?   $	��Top=�6S   �� 5   
   -   5         ��Name$ CustomerIdtxt��5      $
��Left=�6)   $��
173,64,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��194��6�   ${�False��6�   $
��Bold"�5   &   ��5      ��  �� Path$ 
CustomerId� �� Mode$ OneWay=� � DataContext 5      ��  �� ElementName$ lvCustomers��$ SelectedItem�5   &   �� 5   
   -   5        $ CustomerFullNametxt��5      $
��Left=�6/   $��173,108,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��194��6�   ${�False��6�   $
��Bold"�5   &   ��5      �� $ CustomerFullName�$ OneWay=� 5      �� $ lvCustomers��$ SelectedItem�5   &   �� 5   
   -   5        $ Telephonetxt��5      $
��Left=�6(   $��173,154,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��194��6�   ${�False��6�   $
��Bold"�5   &   ��5      �� $ 	Telephone�$ OneWay=� 5      �� $ lvCustomers��$ SelectedItem�5   &   �� 5   
   $��Email Address��6   $
��Left=�6(   $��
37,192,0,0q�6C   $	��Top=�6W   �� 5   
   $��Customer Birthday��6   $
��Left=�6,   $��
37,232,0,0q�6G   $	��Top=�6[   �� 5   
   -   5        $ EmailAddresstxt��5      $
��Left=�6+   $��173,192,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��194��6�   ${�False��6�   $
��Bold"�5   &   ��5      �� $ EmailAddress�$ OneWay=� 5      �� $ lvCustomers��$ SelectedItem�5   &   �� 5    
   -   5        $ CustomerBirthdaytxt��5       $
��Left=�6/   $��173,240,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��194��6�   ${�False��6�   $
��Bold"�5#   &   ��5!      �� $ CustomerBirthday�$ OneWay=� 5"      �� $ lvCustomers��$ SelectedItem�5#   &   �� 5$   
   -   5         ��Name$ 	Updatebtn��5$      $��Update��6$   $
��Left=�65   $��214,284,0,0q�6P   $	��Top=�6e   $��32��6}   $��56��6�   5%      �� 5&   
   -   5        $ 	Deletebtn��5&      $��Delete��6$   $
��Left=�65   $��311,284,0,0q�6P   $	��Top=�6e   $��32��6}   $��56��6�   5'      �� 5(   
   -   5        $ 	Insertbtn��5(      $��Insert new user��6$   $
��Left=�6>   $��
27,284,0,0q�6Y   $	��Top=�6m   $��32��6�   $	��118��6�   5)      �� 5*   
   -	   5        	 ��Name$	 lvCustomers��5*      $��
400,0,0,10q�6S   $	��NaN��6g   
 �� View
 5+      �� 5,      .P�5-      �� $��Customer ID��6%    �� Width$	 100��6:    �� DisplayMemberBinding 6F   �� $ 
CustomerId��� 5.      $��Customer Full Name��6%   $	 150��6A    6M   �� $ CustomerFullName��� 5/      $��	Telephone��6%   $	 100��68    6D   �� $ 	Telephone��� 50      $��Email Address��6%   $	 200��6<    6H   �� $ EmailAddress��� 51      $��Customer Birthday��6%   $	 100��6@    6L   �� $ CustomerBirthday�52      54      �� 55   
   -
   5        $ Closebtn��55      $��Close��6#   $
��Left=�63   $��
27,365,0,0q�6N   $	��Top=�6b   $��64��6�   �� 56   
   -   5        $ 	SearchBtn��56      $��Search��6$   $
��Left=�65   $��
247,15,0,0q�6P   $	��Top=�6d   6|   �� 57   
   -   5        $ 
keyWordtxt��57      $
��Left=�6&   $��	96,15,0,0q�6A   $
 Wrap=�6T   $	��Top=�6h   $	��146��6�   $��20��6�   58      59      