   M S B A M L   `   `   `  ����E  AWPFMecaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MecaAppMecaApp  5   	   E ADataAccess, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI3clr-namespace:DataAccess.Models;assembly=DataAccessDataAccess.Models 5   	       MecaApp.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MecaApp     5   	   FModels3clr-namespace:DataAccess.Models;assembly=DataAccess     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$1  +مکا - دستیار مکانیک برتر��5   	   $	��620��5   	   $	��800��5   	      Wins#��[  5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  
 myGrid#��[ 6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��4q�5      
�������$��2q�5      
������� �� CornerRadius$ 4��5       �� Padding$ 0,20,0,0q�6"   ._�5      �� $	��0 0q�6   .+�5      �� -   5         ��Name$ btnTime��5        
MaiButtons#��[ 5      .��5       �� "  FontAwesome.WPF.ImageAwesome  5!         Icon$ ClockOutline=�6.     fontAwesome#��[ 6B    �� 5"        
buttonText#��[ 6$   .��6H   موعد کارها6T   5#      5$      �� 5%      -   5        $ btnRefferal��5&      #��[ 5%      .��5(      �� $��Stretch=�6      5)      $ Truck=�6.   #��[ 6;    �� 5*      #��[ 6$   .��6H   مراجعات6Q   5+      5,      �� 5-      -   5        $ btnUsers��5.      #��[ 5-      .��50      ��   51      $ Users=�6.   #��[ 6;    �� 52      #��[ 6$   .��6H   مشتریان6Q   53      54      �� 55      -   5        $ btnProperty��56      #��[ 55      .��58      ��   59      $
 Cogs=�6.   #��[ 6:    �� 5:      #��[ 6$   .��6H   
قطعات6O   5;      5<      5=      5>      �� 5@   
   $��1��6   $��4q�6!   $��2q�6,   
�������$ 4��6S   ��5A      �� 5B       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5C      � 	 � Color$	 #4389A2��6#   
 � Offset$
 0Q�63   � 5D      $	 #5C258D��6#   $
 1Q�63   5E      ._�5G       � -   5        $��	MainFrame��5G      $��Stretch=�5H        � NavigationUIVisibility$ Hidden=�5I       � IsSharedSizeScope$
 True��5J      5K      5L      5M      