   M S B A M L   `   `   `  ����>  :LIT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LITLIT  5   	       LIT.NewDataBaseDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:LIT     5   	     � Title$  NewDataBaseDialog��5   	   $	��350��6#   $	��400��60    � WindowStartupLocation$ CenterScreen=�5	   	   ���#1d1d1d.��5
      ��  �� CornerRadius$ 10��6    �� Padding$ 2q�6   ._�5   
   �� .+�5      �� $ 10��6   ���#353340$	��200��6<   $��40��6H   $��Center=�6T   $��40,50q�6q   ._�5      � .+�5      �� -   5        $��
TBX_Nombre��5   �   $��1q�6   $��0q�6)   
������ $��Center=�6V   $��5q�6x   ���#CFCFCF6�   �� 5       J� IsHitTestVisible .  $��Nombre del archivo��5   (   $��Center=�6B   $
��Left=�6]   $��10,0,0,0q�6x   $��11(�6�   
�������$��1��6�   ��5      �� 5       �� 
TargetType" ��6$    �� Triggers 5   "   �� 5   &    �� Binding 62   �� *Text+ �� ElementName$ 
TBX_Nombre��	 �� Value	  6c   .a�5   *   �� 
 �� Property
 � y� �� Value$ Visible=�6G   6Y   5   '   .�5   "   �� 
 � y�$ Hidden=�6?   5      5      5      5      �� 5!       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5%      �� $ 10��6   ���#353340$	��195��6@   $��40��6L   $��Center=�6X   $��40,0,0,0q�6u   ._�5&      � .+�5'      �� -   5        $��TBX_Path��5'   �   $��1q�6"   $��0q�6-   
������ $��Center=�6Z   $��5q�6|   ���#CFCFCF6�   �� 5(       .  $��Ruta del archivo��5)   (   $��Center=�6@   $
��Left=�6[   $��10,0,0,0q�6v   $��11(�6�   
�������$��1��6�   ��5*      �� 5+   "   " ��6(    5,   &   �� 5-   *    66   �� *Text+$ TBX_Path��	  6e   .a�5.   .   �� 
 � y�$ Visible=�6K   6]   5/   +   .�51   &   �� 
 � y�$ Hidden=�6C   52   #   54      55      56      �� 59      $��5 0 0 0q�6    � Cursor$
 Hand��6*   $ 10��68   
������ $��35��6d   ���	#FF65BD0D$��50��6�   $��Center=�6�   ._�5:      �� -   5        $��BTNSelectFolder��5:   a   $
 Hand��6    . $��Examinar��6x   $��Center=�6�   
������ ���	#FF65BD0D$	��210��6�   $��12(�6�   $��Center=�6�   $��0,5,0,5q�6  $��Center=�6#  $��SemiBold"�6E  $��50��6\  5;      5=      �� 5A      $��0 10 0 0q�6   $
 Hand��6'   $ 10��65   
������ $��35��6a   ���	#FF65BD0D$	��210��6�   $��Center=�6�   ._�5B      �� -   5        $��BtnCreateDataBase��5B   _   $
 Hand��6    . $��Añadir��6x   $��Center=�6�   
������ ���	#FF65BD0D$	��210��6�   $��28(�6�   $��Center=�6�   $��0,5,0,5q�6  $��Center=�6!  $��SemiBold"�6C  $��50��6Z  5C      5E      5F      5G      