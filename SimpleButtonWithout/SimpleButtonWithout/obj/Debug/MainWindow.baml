   M S B A M L   `   `   `  ����N  JSimpleButtonWithout, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SimpleButtonWithoutSimpleButtonWithout  5   	   O,clr-namespace:SimpleButtonWithout.ViewModelsSimpleButtonWithout.ViewModels  5   	   $    SimpleButtonWithout.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:SimpleButtonWithout     5   	   C
ViewModels,clr-namespace:SimpleButtonWithout.ViewModels     5   	     � Title$  
MainWindow��5	   	   $	��350��6   $	��525��6)    � DataContext 5
      2   ,SimpleButtonWithout.ViewModels.MainViewModel  5   
   .��5      � .+�5   
   �� -   5         ��Name$ button��5      $��Button��6!   $
��Left=�62   $��356,135,0,0q�6M   $	��Top=�6b   $��75��6z   ��6�   �� *OnButtonClickedCommand+�� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��216,204,0,0q�6B   $
��Wrap=�6W   $	��Top=�6�   ��6k   �� *Output+6�   �� 5   
   -   5         ��Name$ checkBox��5      $��CheckBox��6%   $
��Left=�68   $��162,105,0,0q�6S   $	��Top=�6h    d� 	IsChecked 6�   �� *IsClickable+5      5      