   M S B A M L   `   `   `  ����E  AWPFMecaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPFMecaApp.WindowsWPFMecaApp.Windows  5   	   *    $WPFMecaApp.Windows.UserDetailsWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPFMecaApp.Windows     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  68     � 
ResizeMode$  NoResize=�5   	      Wins#��[  5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ اطلاعات مشتری��5   	   $	��607��6   $	��400��6,    � 	Resources 5        carViewSource��%   &	       �� 5   
   6   5      .��5      �  
 myGrid#��[ 6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $!��اطلاعات مشتری
��6#   .��5      �� .+�5      �  5      �� 5      �� 5       � RowDefinitions 5      �� 5      �� 5      �� 5      .+�5       �� $��0��6   $��0��6)   $��نام مشتری:��69   �� 5!      -   5        $��labelUserName��5!   Q   $��0��6   $��1��6)   $��نیما ابراهیمی��69   6Q   �� 5"      $��1��6   $��0��6)   $��شماره تماس:��69   �� 5#      -   5        $��labelPhoneNumber��5#   O   $��1��6   $��1��6)   $��09369785462��69   6O   �� 5%      $��2��6   $��0��6)   $
��Left=�69   $!��تعداد ماشین ها:��6O   �� 5&      -   5        $��labelCarsNumber��5&   \   $��2��6   $��1��6)   $��Right=�69   $��5��6P   6\   5'      � 5(      $	��416��6    5)      �� 5*      $��* �6+   �� 5+      $��* �6+   .+�5-      �� -   5        $��carsListView��5.      $��0��51   E   ��5/      ��  �� Source# [  �� View 52      �� 53       �� AllowsColumnReorder$
 true��6'   .P�55   "   �� 	 �� Width$
	 auto��6\   
 �� DisplayMemberBinding
 61   ��  �� Path$
 Name�.��56   &   �� .��6;   نام � ContextMenu 57   *   �� 58   .   -   5        $
��Name��58   :   .@�59   2   m� $��	Ascending��6;   m� 5:   2   $��
Descending��6;   5;   /   5=   '   5>   #   �� 5?   "   $
	 auto��6b   
 61   �� $ 
RunPerYear�.��5@   &   �� .��6;   
مسافت 5A   *   �� 5B   .   -   5        $��km��5B   :   .@�5C   2   m� $��	Ascending��6;   m� 5D   2   $��
Descending��6;   5E   /   5G   '   5H   #   5I      5K      �� 5L      $��1��6!   $��Center=�5M   !   $	��194��5N   !   $��Center=�5O   !   .+�5P      �� -   5        $��buttonAddCar��5Q   !     
BtnSuccess#��[ 5P   !   $	��130��5S   !   $	��NaN��6-   $��	0,20,0,20q�5T   !   $��Stretch=�5U   !   $��20,5,0,5q�5V   !   .��5W      �� "  FontAwesome.WPF.ImageAwesome  5X   "      Icon$ 
PlusSquare=�62     fontAwesomeAction#��[ 5Y   2   $��0,5,0,10q�6]    �� 5Z   "     
buttonText#��[ 6(   .��6L   افزودن6T   5[      5\      �� 5]      -   5        $��buttonEditCar��5^   !     
BtnWarning#��[ 5]   !   $��	0,20,0,20q�5`   !   $	��130��64   $��Stretch=�5a   !   $��15,5,5,5q�5b   !   .��5c      ��   5d   "   $
 Edit=�62   #��[ 5e   2   $��0,5,0,10q�6]    �� 5f   "   #��[ 6(   
���   �.��6_   ویرایش6g   5g      5h      �� 5i      -	   5        $��buttonRemoveCar��5j   !     	BtnDanger#��[ 5i   !   $	��130��5l   !   $��20,20,20,20q�6-   $��Stretch=�5m   !   $��15,5,5,5q�5n   !   .��5o      ��   5p   "   $ TrashOutline=�62   #��[ 5q   2   $��0,0,0,8q�5r   2    �� 5s   "   #��[ 6(   $��0,0,0,0q�6L   .��6]   حذف6b   5t      5u      5v      5w      5x      5y      5z      5{      