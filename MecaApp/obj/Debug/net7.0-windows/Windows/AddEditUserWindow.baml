   M S B A M L   `   `   `  ����E  AWPFMecaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFMecaApp
WPFMecaApp  5   	   "    WPFMecaApp.AddEditUserWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPFMecaApp     5   	     � 
ResizeMode$  NoResize=�5   	      Wins#��[  5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ 
مشتری��5   	   .��5      �  
 myGrid#��[ 6    � RowDefinitions 5   
   �� 5      $��7* �6   �� 5      $��3* �6   .+�5   
   �� $��0��6   .+�5      �� $��نام مشتری:��6   �� 5      -   5        $��textboxUserName��5      6-   �� 5      $��شماره تلفن:��6   �� 5      -   5        $��textboxPhoneNumber��5       �� 	MaxLength$ 11��5       �� AutoWordSelection$
 True��6%   5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5        $��	btnSubmit��5      $��
ذخیره��6&   ${�False��66     
BtnSuccess#��[ 5      69   �� 5      -   5        $��	btnCancel��5      $��انصراف��6&     	BtnDanger#��[ 67   5      5      5      5       