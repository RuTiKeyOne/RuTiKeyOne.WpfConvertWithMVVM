   M S B A M L   `   `   `  ����M  IWpfConvertWithMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfConvertWithMVVMWpfConvertWithMVVM  5   	   K*clr-namespace:WpfConvertWithMVVM.ViewModelWpfConvertWithMVVM.ViewModel  5	   	   #    WpfConvertWithMVVM.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfConvertWithMVVM     5   	   @	viewmodel*clr-namespace:WpfConvertWithMVVM.ViewModel     5	   	   -   5          �Name$
  Main��5   	    � Title$ 
MainWindow��5
   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�6A    � WindowStyle$
 None=�6W   $	��400��6k   $	��550��6x   ���#EFEFEF � DataContext 5      0  *WpfConvertWithMVVM.ViewModel.MainViewModel  5   
    � 	Resources 5         CloseButton �� 
TargetType �� Property	 �� Value��%`  &	        �� 5   
   " ��6$   .�5      ��  � ��$	 0q�60   �� 5       � ��$	 Right=�64   �� 5       � ��	 5      �� 5      .R�5      �� $��Center=�6    $��Center=�6D   $��25��6f   $��35��6r   ���#BD0F10.��5      �� 
�������$��12(�6;   $��x��6I   6T   5      5      5      5      5      .��5      �� .+�5   
   �� #��[  6   ��66   �� *	CloseMain+��6T   �� 
 �� ElementName$

 Main��5       � 5!   
    � ColumnDefinitions 5"      �� 5#      $	��175 �6#   61   �� 5$      6%   .+�5&      �� $��0��6   .+�5'      �  � RowDefinitions 5(      �� 5)      $	��150 �6(   67   �� 5*      $	��225 �6(   67   .+�5,      � ���#8D47DE 5-      �� 5.      $	��100 �6,   6;   �� 5/      6.   .+�51      �� $��0��6    $"��/View/Images/ConvertIcon.png��6-   $��80��6S   6`   �� 52      $��
ExtraLight"�6$   $��1��6<   ���#FFFFFF$��Center=�6^   $��30(�6{   $��	Converter��6�   6�   53      � 54      $��1��6   ���#7438BC 55      �� 56      6.   �� 57      6.   �� 58      6.   �� 59      6.   .+�5;      �� $��OfficeToPdf��6G   $��
ExtraLight"�6f   $��16(�6~   $	��125��6�   $��0��6�   $��Office to Pdf��6�   ��6!   �� *UpdateViewCommand+6�   �� 5<      $��ImagesToPdf��6G   $��
ExtraLight"�6f   $��16(�6~   $	��125��6�   $��1��6�   $��Images to Pdf��6�   ��6!   �� *UpdateViewCommand+6�   �� 5=      $��
EbookToPdf��6G   $��
ExtraLight"�6e   $��16(�6}   $	��125��6�   $��2��6�   $��Ebook to Pdf��6�   ��6!   �� *UpdateViewCommand+6�   �� 5>      $��	PdfToText��6G   $��
ExtraLight"�6d   $��16(�6|   $	��125��6�   $��3��6�   $��Pdf to Text��6�   ��6!   �� *UpdateViewCommand+6�   5?      5@      5A      �� 5B      $��1��6   ��6-   �� *SelectedViewModel+6U   5C      5D      5E      