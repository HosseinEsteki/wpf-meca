   M S B A M L   `   `   `  ����E  AWPFMecaApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFMecaApp
WPFMecaApp  5          WPFMecaApp.SegmentsPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:WPFMecaApp     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  6.   -   5         	  Pages#��[  5        N� Title$  SegmentsPage��5       � 	Resources 5        segmentViewSource��%   &	       �� 5   
   6   5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��8* �6   �� 5      $��2* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SegmentGrid��5      $��0��5       	 Grids#��[ 5      ��5      ��  �� Source# [ 5      �� 5   
   $��1��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   .+�5      �� -   5        $��	buttonAdd��5        
BtnSuccess#��[ 5      .��5      �� $��Center=�6   $��Center=�69   "  FontAwesome.WPF.ImageAwesome  5         Icon$ 
PlusSquare=�6&     fontAwesomeAction#��[ 68    �� 5         
buttonText#��[ 6   .��6@   افزودن6H   5!      5"      �� 5#      -   5        $��
buttonEdit��5$        
BtnWarning#��[ 5#      ${�False��5%      .��5'      ��   5(      $
 Edit=�6&   #��[ 62    �� 5)      #��[ 6   
���   �.��6S   ویرایش6[   5*      5+      �� 5,      -   5        $��buttonDelete��5.        	BtnDanger#��[ 5,      ${�False��5-      .��50      ��   51      $ TrashOutline=�6&   #��[ 6:    �� 52      #��[ 6   .��6@   حذف6E   53      54      55      56      57      