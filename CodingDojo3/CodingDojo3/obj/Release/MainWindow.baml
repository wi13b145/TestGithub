   M S B A M L   `   `   `  ���� F  BCodingDojo3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:CodingDojo3.ViewModelCodingDojo3.ViewModel      CodingDojo3.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     2vm#clr-namespace:CodingDojo3.ViewModel       � Title$.  (CodingDojo3 - wi13b145 - Johannes Bickel��$	��458��$	��565�� � Icon$ Images/dojo.png��$	��565��$	��565��$	��458��$	��458�� � DataContext )  #CodingDojo3.ViewModel.MainViewModel  .���  � RowDefinitions �� $	��51* ��� $
��202* ��� $	��66* �.+�&   System.Windows.Controls.DataGrid  $��Stretch=�$��1��$��Stretch=�   AutoGenerateColumns .     CanUserDeleteRows . ���� *Items+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $ Group�� �� *Group+  $ 
Salesprice�� �� *
SalesPrice+  $ Purchase Price�� �� *PurchasePrice+  $ On Stock�� �� *	OnStock+4  .System.Windows.Controls.DataGridTemplateColumn  	   CellTemplate	 �� .R�A� 
��� � ��� $
��Left=�$��
87,19,0,10q�$��Center=�$	��120������ *
Currencies+
 �� SelectedItem
 �� *SelectedCurrency+�� $��Currency��$
��Left=�$��	10,27,0,0q�$	��Top=�$
��Bold"��� -    ��Name$ lblTextInfo��$<��6To delete, please select a row and press the "Del"-Key��$
��Left=�$��	10,10,0,0q�$��2��$	��Top=��� $8��2To edit, please select a field and double click it��$
��Left=�$��	10,36,0,0q�$��2��$	��Top=��� $	��Add��$
��Left=�$��
421,21,0,0q�$��2��$	��Top=�$��75������ *
ButtonTest+