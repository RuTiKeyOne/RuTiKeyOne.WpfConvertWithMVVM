   M S B A M L   `   `   `  ����M  IWpfConvertWithMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:WpfConvertWithMVVM.View.UserControls$WpfConvertWithMVVM.View.UserControls  5      K*clr-namespace:WpfConvertWithMVVM.ViewModelWpfConvertWithMVVM.ViewModel  5      @    :WpfConvertWithMVVM.View.UserControls.EbookToPdfUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:WpfConvertWithMVVM.View.UserControls     5      @	viewmodel*clr-namespace:WpfConvertWithMVVM.ViewModel     5      ���#EFEFEF  � DataContext  5
      0  *WpfConvertWithMVVM.ViewModel.MainViewModel  5   
   .��5      ]� $	��320��6   $	��280��6   ���#7438BC.+�5   
   � $��Center=�6   $	��240��6*    � RowDefinitions 5      �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      $��50 �6    6.   .+�5      �� $��0��6   $��
Ebook File��6%   $��24(�67   $��
ExtraLight"�6E   ���#FFF6q   A� 5      $��1��6    A� Columns$ 2��6'   .+�5      ��  �� 
IsReadOnly$
 true��64    �� TextWrapping$
 Wrap=�6F   $��12(�6Z   $��10q�6h   ���#FFF$��
ExtraLight"�6�   ��6   �� *
FileName+6�   �� 5      $��Ebook file|*.epub;*.modi��6<   $��Choose��6h   ��6   �� *OpenFileDialog+6{   5      �� 5      $��2��6   $��Where to Save:��6%   $��24(�6;   $��
ExtraLight"�6I   ���#FFF6u   A� 5      $��3��6   $ 2��6'   .+�5      �� $
 True��66   $
 Wrap=�6H   $��10q�6\   ���#FFF$��
ExtraLight"�6z   $��12(�6�   ��6   �� *
FolderName+6�   �� 5      $��Choose��6>   ��6   �� *OpenFolderDialog+6Q   5      �� 5       $
��.pdf��68   $��4��6Q   $	��150��6^   $��Convert��6j   ��6   �� *ConvertCommand+6~   5!      5"      5#      