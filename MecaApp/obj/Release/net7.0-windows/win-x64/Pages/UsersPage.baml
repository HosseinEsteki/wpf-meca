   M S B A M L   `   `   `  ���� E  AWPFMecaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFMecaApp
WPFMecaApp      WPFMecaApp.UsersPage   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     *localclr-namespace:WPFMecaApp     Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  -    	  Pages#��[    N� Title$  مشتریان�� � 	Resources   userViewSource��%   &	       �� .��� $��10q� � RowDefinitions �� $��8* ��� $��2* �.+�&   System.Windows.Controls.DataGrid  -     Name$ UserGrid��$��0�� 	 Grids#��[ ����  �� Source# [ �� $��1��$��Center=� �� Orientation$ 
Horizontal=�.+��� -   $��	buttonAdd��  
BtnSuccess#��[ .���� $��Center=�$��Center=�"  FontAwesome.WPF.ImageAwesome     Icon$ 
PlusSquare=�  fontAwesomeAction#��[  ��   
buttonText#��[ .��افزودن�� -   $��
buttonEdit��  
BtnWarning#��[ ${�False��.����   $
 Edit=�#��[  �� #��[ 
���   �.��ویرایش�� -   $��buttonDelete��  	BtnDanger#��[ ${�False��.����   $ TrashOutline=�#��[  �� #��[ .��حذف�� -   $��buttonDetails��  
BtnPrimary#��[ ${�False��.����   $ 
InfoCircle=�#��[  �� #��[ .��جزئیات