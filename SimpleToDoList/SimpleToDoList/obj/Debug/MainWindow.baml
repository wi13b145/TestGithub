   M S B A M L   `   `   `  ����I  ESimpleToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SimpleToDoListSimpleToDoList  5   	   E'clr-namespace:SimpleToDoList.ViewModelsSimpleToDoList.ViewModels  5   	       SimpleToDoList.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SimpleToDoList     5   	   >
ViewModels'clr-namespace:SimpleToDoList.ViewModels     5   	     � Title$  SimpleToDoList��5	   	   $	��333��6    $	��500��6-    � DataContext 5
      -  'SimpleToDoList.ViewModels.MainViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��7* �6   �� 5      $
��486* �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��2��6;   $��Center=�6O   .+�5      �� $
��ToDo��6   $��Center=�6#   $
��10,0q�6>   �� 5      $	��150��6   $��Center=�6F   $
��10,0q�6a   ��6"   �� *NewTaskDescription+6a   �� 5      -   5         ��Name$ button��5      $	��Add��6Q   $��Center=�6_   $��Center=�6z   $��30��6�   $��55��6�   ��6%   �� *AddButtonClickedCommand+6�   5      �� 5   
   $��1��6   $��2��6"   $��0,0,0.333,0q�66   .+�5      &   System.Windows.Controls.DataGrid  $��5q�6   $��Center=�6"      AutoGenerateColumns .  ��6=   �� *
ToDoList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Description��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� *Description+
   ClipboardContentBinding
 6^   Z� 4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $
 Done��6-   	 6;   �� *Done+5"      5#      5%      5&      