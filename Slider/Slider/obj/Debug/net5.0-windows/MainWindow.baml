   M S B A M L   `   `   `  ����A  =Slider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SliderSlider  5   	       Slider.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Slider     5   	   -   5        $��
OknoGlowne��5   5     � Title$  
MainWindow��6	   $	��450��6   $	��800��6)    � 	Resources 5	      )  #Slider.RGBComponentToColorConverter    RGBComponentToColorConverter��%   &	          5
   
   6-   5      .��5      �� .+�5   
   � .+�5      �� $
��Red:��6   $��20(�6$   $
��Bold"�62   $	��100��6D   �� 5      $��20��6   $	��200��6!    � Minimum$ 0Q�6-    � Maximum$	 255Q�69    �� TickFrequency$ 1Q�5       �� IsSnapToTickEnabled$
 True��6'    � Value 6B   ��  �� ElementName$ 
OknoGlowne�� �� Path$ RedComponent��� 5      ��6   �� $ 
OknoGlowne��$ RedComponent�5      � 5   
   .+�5      �� $��Blue:��6   $��20(�6%   $
��Bold"�63   $	��100��6E   �� 5      $��20��6   $	��200��6!   $ 0Q�6-   $	 255Q�69   $ 1Q�5      $
 True��6'    6B   �� $ 
OknoGlowne��$ BlueComponent��� 5      ��6   �� $ 
OknoGlowne��$ BlueComponent�5      � 5   
   .+�5      �� $��Green:��6   $��20(�6&   $
��Bold"�64   $	��100��6F   �� 5      $��20��6   $	��200��6!   $ 0Q�6-   $	 255Q�69   $ 1Q�5      $
 True��6'    6B   �� $ 
OknoGlowne��$ GreenComponent��� 5      ��6   �� $ 
OknoGlowne��$ GreenComponent�5      �� 5   
   $	��100��6   $	��100��6    ��5    
   `� 5!      	 `� 	Converter#	 [  6   .1�5"      �� $ 
OknoGlowne��6   $ RedComponent�63   
 �� Mode$
 OneWay=�6G   �� 5#      $ 
OknoGlowne��6   $ GreenComponent�63   $
 OneWay=�6I   �� 5$      $ 
OknoGlowne��6   $ BlueComponent�63   $
 OneWay=�6H   5%      5'      5(      5)      