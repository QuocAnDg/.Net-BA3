   M S B A M L   `   `   `  ����F  BWpfEmployee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfEmployeeWpfEmployee  5   	       WpfEmployee.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfEmployee     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��35 �6   �� 5      $��* �6   $	��100��6'   �� 5      $��35 �6   �� 5      $	��200 �6   �� 5      $��35 �6   $��35��6(   .+�5   
   �� $��6q�6   $��	Employees��6   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgCustomers��5      $��6q�6&   $��1��61      AutoGenerateColumns$ False��6>      
IsReadOnly$
 True��6�    �� SelectedItem 6Z   �� *SelectedEmployee+��6�   �� *EmployeesList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Full Name��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
FullName+6U     5      $ 
Birth Date��6J   $ * 6^    6%   �� *DisplayBirthDate+6^   5      �� 5   
   $��2��6   $��6,6,87,6q�6   $��12(�6/   $
��Bold"�6=   .��6P   MVVM6V   �� 5   
   $	��Add��60   $��75��6>   $��6,6,87,6q�6I   $��2��6[   $��Right=�6h   ��6   �� *
AddCommand+6h   �� 5   
   $��Remove��6   $��75��6"   $��6q�6-   $��2��68   $��Right=�6E   � 5   
   $��3��6   $��6q�6   	 � DataContext	 6'   �� *SelectedItem+
 �� ElementName$
 dgCustomers�� � ColumnDefinitions 5      �� 5       $	��100 �6#   �� 5!      $��* �6#   �� 5"      $��* �6#   .+�5$      �� .+�5%      �� $��Last Name :��6   $��6q�6.   �� 5&      $��First Name :��6   $��6q�6/   �� 5'      $��Title :��6   $��6q�6*   �� 5(      $��Birth Date :��6   $��6q�6/   �� 5)      $��Hire Date :��6   $��6q�6.   5*      �� 5+      $��1��6   .+�5,      �� $��27��6   $��6,6,6,5q�6&   ��67   �� *
LastName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5-      $��27��6   $��6,6,6,5q�6&   ��67   �� *	FirstName+$ PropertyChanged=��� 50      -   5        $��cbTitle��50      $��27��6*   $��6,6,6,5q�66   ��51      �� *DataContext.ListTitle+ �� RelativeSource �� *FindAncestor+ �� AncestorType" � 54      �� *TitleOfCourtesy+(  "System.Windows.Controls.DatePicker  55      $��27��6   $��6,6,6,5q�6)      SelectedDate 6:   �� *	BirthDate+  56      $��27��6   $��6,6,6,5q�6)    6:   �� *
HireDate+57      �� 58      $��2��6   .+�59        -   5        $��dgOrders��59      $��6q�6+   $��1��66   $ False��6C   $
 True��5;   5   ��59   _   �� *DataContext.LastThreeOrders+ �� *FindAncestor+" � 5<        5>      $ OrderId��6I   $ * 6Z    6-   �� *	OrderId+6Z     5?      $ 	DateOrder��6R   $ * 6e    6-   �� *DisplayDateOrder+6e     5@      $ 
TotalOrder��6L   $ * 6`    6-   �� *
OrderTotal+6`   5B      5D      5E      �� 5F   
   $
��Save��62   $��75��6A   $��6,6,87,6q�6L   $��4��6^   $��Right=�6k   ��6   �� *SaveCommand+6k   �� 5G   
   $��Cancel��6   $��75��6"   $��6q�6-   $��4��68   $��Right=�6E   5H      5I      