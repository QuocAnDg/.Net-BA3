   M S B A M L   `   `   `  ����B  >seance8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:seance8seance8  5   	       seance8.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:seance8     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1058��6)    � 	Resources 5	         
TitreStyle �� Property �� Value  
LabelStyle  ItemTemplate �� Orientation��%  &	        &	 �     &	 �     �� 5
   
   .�5      ��  � ��$ 18(�6/   �� 5       � ��
 �   �62   �� 5       � ��$ 2q�66   5      �� 5   
   .�5      ��  � ��$ courier new)�61   5      �� 5   
   .R�5      �� $ 
Horizontal=�6   $��0 5 0 5q�63   .+�5      �� $��50��6   $��50��6#   $
��Fill=�6/   $��Center=�6W   $��Center=�6r   ��6>   �� *Image+6r   �� 5      $��Center=�68   $��Center=�6S   ��6   �� *Description+6S   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��204* �6   �� 5      $
��251* �6   �� 5      $
��469* �6   �� 5      $
��135* �6   .+�5!   
   �� -   5         ��Name$ listBoxPhotos��5!      $��10,10,228,10q�6A   #��[ 6W   $��2��6�   ��6)   �� 6�   �� 5"   
   -   5         ��Name$ image1��5"      $
��Left=�6    $	��423��6;   $��	52,46,0,0q�6H   $	��Top=�6[   $	��550��6s   $
��Fill=�6   $��1��6�   $��2��6�   �� 5#   
   $��
Top Places��6   $
��Left=�6%   $��	145,0,0,0q�6@   $	��Top=�6S   $	��112��6k   #��[  6w   $��1��6�   $��2��6�   �� 5$   
   $��Description : ��6   $
��Left=�6)   $��
39,488,0,0q�6D   $	��Top=�6X   #��[ 6p   $��1��6�   �� 5%   
   $��URI Fichier :��6   $
��Left=�6(   $��
39,528,0,0q�6C   $	��Top=�6W   #��[ 6o   $��1��6�    J� RenderTransformOrigin$ 
0.37,1.774&�6�   �� 5&   
   $��
Nb Votes :��6   $
��Left=�6%   $��
39,589,0,0q�6@   $	��Top=�6T   #��[ 6l   $��1��6�   $ 0.468,1.759&�6�   �� 5'   
   -   5        $��description_value��5'      $
��Left=�6u   $��154,488,0,0q�6�   $	��Top=�6�   $	��558��6�   $��1��6�   $��32��6�   $��2��6�   ��6)   �� 	 �� ElementName$	 listBoxPhotos��
 �� Path$
 SelectedItem.Description�6�   �� 5(   
   -   5        $��	uri_value��5(      $��152,528,5,0q�6!   $	��Top=�66   $	��562��6N   $��52��6Z   $��1��6f   $��2��6v   .��5)      �� $��WrapWithOverflow=�6Z   ��6   �� $	 listBoxPhotos��$
 SelectedItem.Path�6Z   5+      �� 5,   
   -   5        $��votes_value��5,      $
��Left=�6k   $��152,592,0,0q�6�   $	��Top=�6�   $	��266��6�   $��1��6�   $��24��6�   $��2��6�   ��6#   �� $	 listBoxPhotos��$
 SelectedItem.NbVotes�6�   5/      50      