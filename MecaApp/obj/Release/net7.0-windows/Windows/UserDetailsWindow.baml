   M S B A M L   `   `   `  ���� E  AWPFMecaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPFMecaApp.WindowsWPFMecaApp.Windows  *    $WPFMecaApp.Windows.UserDetailsWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:WPFMecaApp.Windows     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/    � 
ResizeMode$  NoResize=�   Wins#��[   � WindowStartupLocation$ CenterScreen=� � Title$ اطلاعات مشتری��$	��607��$	��400�� � 	Resources   carViewSource��%   &	       �� .���  
 myGrid#��[  � ColumnDefinitions �� $��* �.+��� $��0��$!��اطلاعات مشتری
��.���� .+��  �� ��  � RowDefinitions �� �� �� .+��� $��0��$��0��$��نام مشتری:���� -   $��labelUserName��$��0��$��1��$��نیما ابراهیمی���� $��1��$��0��$��شماره تماس:���� -   $��labelPhoneNumber��$��1��$��1��$��09369785462���� $��2��$��0��$
��Left=�$!��تعداد ماشین ها:���� -   $��labelCarsNumber��$��2��$��1��$��Right=�$��5��� $	��416�� �� $��* ��� $��* �.+��� -   $��carsListView��$��0������  �� Source# [  �� View ��  �� AllowsColumnReorder$
 true��.P��� 	 �� Width$
	 auto��
 �� DisplayMemberBinding
 ��  �� Path$
 Name�.���� .��نام � ContextMenu �� -   $
��Name��.@�m� $��	Ascending��m� $��
Descending���� $
	 auto��
 �� $ 
RunPerYear�.���� .��
مسافت �� -   $��km��.@�m� $��	Ascending��m� $��
Descending���� $��1��$��Center=�$	��194��$��Center=�.+��� -   $��buttonAddCar��  
BtnSuccess#��[ $	��130��$	��NaN��$��	0,20,0,20q�$��Stretch=�$��20,5,0,5q�.���� "  FontAwesome.WPF.ImageAwesome     Icon$ 
PlusSquare=�  fontAwesomeAction#��[ $��0,5,0,10q� ��   
buttonText#��[ .��افزودن�� -   $��buttonEditCar��  
BtnWarning#��[ $��	0,20,0,20q�$	��130��$��Stretch=�$��15,5,5,5q�.����   $
 Edit=�#��[ $��0,5,0,10q� �� #��[ 
���   �.��ویرایش�� -	   $��buttonRemoveCar��  	BtnDanger#��[ $	��130��$��20,20,20,20q�$��Stretch=�$��15,5,5,5q�.����   $ TrashOutline=�#��[ $��0,0,0,8q� �� #��[ $��0,0,0,0q�.��حذف