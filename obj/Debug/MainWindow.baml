   M S B A M L   `   `   `  ����F  BWpfApplab_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfApplab_7WpfApplab_7  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   1&clr-namespace:System;assembly=mscorlibSystem 5   	       WpfApplab_7.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfApplab_7     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)      WindowStyle#���   65    � 	Resources 5      ��%    5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ local:MyCommands.Exit��5      6Q     5   
   -   5        $
 Open��5      6(     5   
   -   5        $
 Save��5      6(   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   o� -   5         o�Name$ 	styleMenu��5      $��0��6"   $��5q�6/   $��5q�6:     Menu#���  6G   .@�5      m� $��Файл��6     MenuItem#���  6%   .@�5      m� $��Открыть��6    m� Command$
 Open��6-   #���  6<   m� 5      $��Сохранить��6   $
 Save��6.   #���  6=   �� 5      m� 5      $��Закрыть��6   $ local:MyCommands.Exit��6,   #���  6L   5       �� 5!      -   5         ��Name$ styleBox��5!      5#      5$      `� 5&   
   $��1��6   $��5q�6#     ToolBarTray#���  6.   .�5(      c�   ToolBar#���  6   .@�5)      �� -   5        $ 
fontFamily��5)      $��5q�6/   $��5q�6:    �� SelectedIndex$ 0��6F   $	��200��6X     
fontfamily#��[ 6e     ComboBox#���  6�   �� 5*      -   5        $ fontSize��5*      $��5q�6-   $��5q�68   $ 2��6D   $��50��6V     fontsize#��[ 6b   #���  6�   5+      c� 5,      #���  6   .@�5-      �� -   5         
 Button#���  5-   .   .��5.      �� $��data/bold-button.png��6   $��40��6:   5/      �� 50      �� 51      -	   5        #���  51   0   .��52      �� $��data/italic.png��6   $��40��65   53      �� 54      �� 55      -
   5        #���  55   0   .��56      �� $��data/underline.png��6   $��40��68   57      59      c� 5;      #���  6   .@�5<      �� $��Center=�6   .+�5=      	� -   5        $��Чёрный��5=   "    	 RadioButtonStyle1#��� 	 6R   	� 5>      -   5        $��
Белый��5>   "    
 RadioButtonStyle2#��� 
 6Q   	� 5?      -   5        $��Красный��5?   "     RadioButtonStyle3#���  6R   5@      5B      5D      �� 5E   
   -   5        	 ��Name$	 textbox��5E      $��2��6#   $��5q�60   $��5q�6;   
 �� TextWrapping$

 Wrap=�6�     TextBoxStyle#���  6�   ��6G   ��  �� ElementName$ fontSize�� �� Path$ SelectedValue���6�   �� $ 
fontFamily��$ SelectedValue�6�   5H      5I      