   M S B A M L   `   `   `  ����>  :LIT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LITLIT  5   	       LIT.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:LIT     5   	     � Title$	  LIT��5   	   $	��500��6    � WindowStartupLocation$ CenterScreen=�6"   $	��600��6G   $
��1000��6W   $
��1000��6g   
���   � � WindowStyle$ ThreeDBorderWindow=�6�   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   � ���#1e1e1e$��0,0,0,0q�6$    5      �� 5      $
��auto �6    �� 5      $��* �6    .+�5      �� -   5        $��TabMenuPrincipal��5   N    � 	Resources 5       �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       '�� �     �� 5      " ��6   .�5      ��  � �� �#EEE67   �� 5       � �� �#21212167   �� 5       � ��$ 0q�6<   5       �� 5!      " ��6   .�5"      ��  � �� �#EEE67   �� 5#       � �� �#1e1e1e67   �� 5$       � ��$ 0q�6<   �� 5%       � �� 5&      �� 5'   "   "	 ��62   .R�5(   &   �� $��Border��6-   $��0,0,0,0q�5)   %   #��z��5*   %   #��z��5+   %   ���#1e1e1e._�5-   *   �� $
 ContentSite��6;   $��Center=�5.   3   $��Center=�5/   3   $��Header��50   3   $��	10,0,10,0q�51   3   ��. 52   3   53   '    54   &   P� 55   *    �@��
IsSelected . . �56   .   �� $ Border��65    � �� �#3434346_   57   +   P� 58   *    �@J�IsMouseOver . . �59   .   �� $ Border��65    � �� �#3333336_   5:   +   5<   #   5>      5?      5@      .@�5A      �� -   5        $��TIContestar��5A   J    � Cursor$
 Hand��6   $��
_Contestar��6(   $��15(�6<   6_   �� 5B      -   5        $��	TIAgregar��5B   T   $
 Hand��6   $��25��6(   $��15(�64   $��_Agregar��6B   6g   5C      � 5F      $��1��6   .+�5G         LIT.UC_AgregarInformacion  -   5          Name$ 
UC_Agregar��5G   .   $y�	Collapsed=�6B   6[      LIT.UC_Contestar  5H      -   5          Name$ UC_Contestar��5H   %   $y�Visible=�6;   6R   5I      5M      5N      5P      