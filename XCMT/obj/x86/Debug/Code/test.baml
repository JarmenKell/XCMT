   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    XCMT   XCMT.Code.test   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   X TXceed.Wpf.Toolkit, Version=2.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f43xwt)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   .s&clr-namespace:System;assembly=mscorlib  5   	   $	��195��5   "   $	��325��6.     � Title$  Einstellungen��6;    � WindowStyle$ 
ToolWindow=�6Q   .��5      �  � ColumnDefinitions 5   
   �� 5      $��7* �6   �� 5	      $��5* �6   �� 5
      $��5* �6   .+�5   
   �� -   5         ��Name$ 
textBlock1��5      $	��Top=�6(   $
��Wrap=�6@   $��	10,10,0,0q�6T   $��0��6g   $��Tickzeit ms��6w   �� 5   
   -   5        $ 
textBlock2��5      $	��Top=�6(   $
��Wrap=�6@   $��	10,35,0,0q�6T   $��0��6g   $��
X Position��6w   �� 5   
   -   5        $ 
textBlock3��5      $	��Top=�6(   $
��Wrap=�6@   $��	10,60,0,0q�6T   $��0��6g   $��
Y Position��6w   �� 5   
   -   5        $ 
textBlock4��5      $	��Top=�6(   $
��Wrap=�6@   $��	10,85,0,0q�6T   $��0��6g   $��Breite��6w   �� 5   
   -   5        $ 
textBlock5��5      $	��Top=�6(   $
��Wrap=�6@   $��
10,110,0,0q�6T   $��0��6h   $��Höhe��6x   �� 5   
   -   5        $ 
textBlock6��5      $	��Top=�6(   $
��Wrap=�6@   $��
10,135,0,0q�6T   $��0��6h   $��Mausgeschwindigkeit��6x   "  Xceed.Wpf.Toolkit.ByteUpDown  5   
   -   5          Name$ UpDown1��5      $��1��6*   $	��Top=�6:   $��0,10,0,0q�6R   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Minimum$ 1X�6d   #  Xceed.Wpf.Toolkit.ShortUpDown  5   
   -   5          Name$ UpDown2��5      $��1��6+   $	��Top=�6;   $��0,35,0,0q�6S     5   
   -	   5        $ UpDown3��5      $��1��6+   $	��Top=�6;   $��0,60,0,0q�6S     5   
   -
   5        $ UpDown4��5      $��1��6+   $	��Top=�6;   $��0,85,0,0q�6S     5   
   -   5        $ UpDown5��5      $��1��6+   $	��Top=�6;   $��	0,110,0,0q�6S     5   
   -   5        $ UpDown6��5      $��1��6*   $	��Top=�6:   $��	0,135,0,0q�6R   $ 1X�6e   �� 5   
   -   5        $ textBlock11��5      $	��Top=�6)   $
��Wrap=�6A   $��	10,10,0,0q�6U   $��2��6h   $��00 FPS��6x   �� 5   
   -   5        $ textBlock12��5      $	��Top=�6)   $
��Wrap=�6A   $��	10,35,0,0q�6U   $��2��6h   $��pixel��6x   �� 5   
   -   5        $ textBlock13��5      $	��Top=�6)   $
��Wrap=�6A   $��	10,60,0,0q�6U   $��2��6h   $��pixel��6x   �� 5   
   -   5        $ textBlock14��5      $	��Top=�6)   $
��Wrap=�6A   $��	10,85,0,0q�6U   $��2��6h   $��pixel��6x   �� 5   
   -   5        $ textBlock15��5      $	��Top=�6)   $
��Wrap=�6A   $��
10,110,0,0q�6U   $��2��6i   $��pixel��6y   �� 5    
   -   5        $ textBlock16��5       $	��Top=�6)   $
��Wrap=�6A   $��
10,135,0,0q�6U   $��2��6i   $��relativ��6y   �� 5"   
   -   5         ��Name$ groupBox��5"      $��Hotkey��6%   $��10,172,10,0q�65   $	��Top=�6J   $��3��6b   $��77��6v   .��5#      � .+�5$      �� -   5         ��Name$ 	checkBox1��5$      $	��Alt��6.   $
��Left=�6<   $��	10,10,0,0q�6W   $	��Top=�6j   �� 5%      -   5        $ 	checkBox2��5%      $
��Strg��6.   $��Center=�6=   $��	0,10,10,0q�6Z   $	��Top=�6m   �� 5&      -   5        $ 	checkBox3��5&      $��Shift��6.   $��Right=�6>   $��	0,10,10,0q�6Z   $	��Top=�6m   �� 5'      -   5        $ 	checkBox4��5'      $	��Win��6.   $
��Left=�6<   $��	10,30,0,0q�6W   $	��Top=�6j   �� 5(      -   5        	 ��Name$	 comboBox��5(      $��Stretch=�6-   $��15��6K   $��
58,30,10,0q�6W   $	��Top=�6k   5)      5*      �� 5,   
   -   5        
 ��Name$
 button1��5,      $��	Speichern��6"   $��10,254,0,10q�66   $	��4,0q�6K   $	��Top=�6Y   $
��Left=�6q   �� 5-   
   -   5        $
 button2��5-      $��	Abbrechen��6"   $��0,254,10,10q�66   $	��4,0q�6K   $	��Top=�6Y   $��Right=�6q   $��2��6�   $��1��6�   5.      5/      