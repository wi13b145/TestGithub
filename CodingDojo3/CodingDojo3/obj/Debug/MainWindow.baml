   M S B A M L   `   `   `  ����F  BCodingDojo3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CodingDojo3.ViewModelCodingDojo3.ViewModel  5   	       CodingDojo3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2vm#clr-namespace:CodingDojo3.ViewModel     5   	     � Title$.  (CodingDojo3 - wi13b145 - Johannes Bickel��5   	   $	��458��6:   $	��565��6G    � Icon$ Images/dojo.png��6S   $	��565��6j   $	��565��6y   $	��458��6�   $	��458��6�    � DataContext 5      )  #CodingDojo3.ViewModel.MainViewModel  5   
   6   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��51* �6   �� 5      $
��202* �6   �� 5      $	��66* �6   .+�5   
   &   System.Windows.Controls.DataGrid  $��Stretch=�6   $��1��61   $��Stretch=�6>      AutoGenerateColumns .     CanUserDeleteRows . ��6v   �� *Items+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+  5      $ Group��6%    64   �� *Group+  5      $ 
Salesprice��6%    69   �� *
SalesPrice+  5      $ Purchase Price��6%    6=   �� *PurchasePrice+  5      $ On Stock��6%    67   �� *	OnStock+4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      A� 
��� � �66   5      5      5       �� 5!   
   $
��Left=�6   $��
87,19,0,10q�6/   $��Center=�6D   $	��120��6_   ��6k   �� *
Currencies+
 �� SelectedItem
 6�   �� *SelectedCurrency+�� 5"   
   $��Currency��6   $
��Left=�6#   $��	10,27,0,0q�6>   $	��Top=�6Q   $
��Bold"�6i   �� 5#   
   -   5         ��Name$ lblTextInfo��5#      $<��6To delete, please select a row and press the "Del"-Key��6%   $
��Left=�6p   $��	10,10,0,0q�6�   $��2��6�   $	��Top=�6�   �� 5$   
   $8��2To edit, please select a field and double click it��6   $
��Left=�6M   $��	10,36,0,0q�6h   $��2��6{   $	��Top=�6�   �� 5%   
   $	��Add��6   $
��Left=�6>   $��
421,21,0,0q�6Y   $��2��6m   $	��Top=�6z   $��75��6�   ��6   �� *
ButtonTest+6�   5'      5(      