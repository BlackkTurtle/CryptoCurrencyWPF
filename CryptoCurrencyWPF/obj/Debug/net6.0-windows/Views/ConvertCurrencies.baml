   M S B A M L   `   `   `  ����L  HCryptoCurrencyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CryptoCurrencyWPF.ViewModelsCryptoCurrencyWPF.ViewModels  5   ?   /    )CryptoCurrencyWPF.Views.ConvertCurrencies   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   ;
viewmodels*clr-namespace:CryptoCurrencyWPF.ViewModels  6?     � Title$  ConvertCurrencies��5	   	   $	��330��6#   $	��450��60   .��5
      � ���#a1a3a6.+�5   
   �� -   5         ��Name$ TextBox1Search��5      $
��Left=�6*   $��93,20,0,227q�6E   $��24��6Z   $	��112��6f   $��18(�6r   $	��Top=�6�   ��6�   �� *TextBox1Name+ �� UpdateSourceTrigger$ PropertyChanged=�.��6�    J� InputBindings 5      �� 5      
 �� Key$ Enter��6M    �� Command 6   ��  �� Path$ TextBox1SearchOnUpdate�6M   .��5   %   5      �� 5   
   -   5         ��Name$ ViewAllAssets��5      $
��Left=�6*   $	��110��6E   $��	77,55,0,0q�6R   $	��Top=�6e   $	��148��6}    �� SelectionMode$ Single=�6�   ��6�   �� *TextBox1Assets+	 �� SelectedItem	 6�   �� *TextBox1SelectedAssets+��5      �� 5      .R�5      � $��14��6    .+�5      �� ��6$   �� $
 name�5      5      5      �� 5   
   -   5        $ TextBox2Search��5      $
��Left=�6*   $��284,20,0,227q�6E   $��24��6[   $	��112��6h   $��18(�6t   $	��Top=�6�   ��6�   �� *TextBox2Name+$ PropertyChanged=�.��6�    5      �� 5      $ Enter��6M    6   �� $ TextBox2SearchOnUpdate�6M   .��5   %   5      �� 5   
   $��From:��6   $
��Left=�6    $��	23,18,0,0q�6;   $	��Top=�6N   $��16(�6f   �� 5   
   $	��To:��6   $
��Left=�6   $��29��69   $��
235,18,0,0q�6E   $	��Top=�6Y   $��35��6q   $��16(�6|   �� 5    
   -   5        $
��Back��5       $
��Left=�6    $��30��6;   $��340,256,0,0q�6G   $	��Top=�6\   $��84��6t   $��16(�6   ���	#FF505152
�������5!      �� 5"   
   $��	Quantity:��6   $
��Left=�6$   $��36��6?   $��
28,179,0,0q�6K   $	��Top=�6_   $��78��6w   $��16(�6�   �� 5#   
   -   5        $ TextBoxQuantity��5#      $
��Left=�6+   $��28��6F   $��106,183,0,0q�6R   
 �� TextWrapping$

 Wrap=�6g   $	��Top=�6{   $	��132��6�   $��16(�6�   ��6�   �� *TextBox3Name+$ PropertyChanged=�.��6�    5$      �� 5%      $ Enter��6N    6   �� $ TextBox3CalculateResult�6N   .��5&   %   5'      �� 5(   
   $��=��6   $
��Left=�6   $��253,181,0,0q�67   $	��Top=�6L   $��16(�6d   �� 5)   
   -   5         ��Name$ TextBlockResult��5)   )   ���#505152$
��Left=�6B   $��28��6]   $��296,183,0,0q�6i   $
��Wrap=�6~   $	��Top=�6�   $	��110��6�   ${�False��6�   $��16(�6�   ���	#FFFBFBFB��6�   �� $ LabelResult�5*      �� 5+   
   -   5        $ ViewAllRates��5+      $
��Left=�6)   $	��110��6D   $��
263,55,0,0q�6Q   $	��Top=�6e   $	��150��6}   $ Single=�6�   ��6�   �� *TextBox2Rates+	 6�   �� *TextBox2SelectedRates+��5,      �� 5-      .R�5.      � $��14��6    .+�5/      �� ��6$   �� $ id�50      51      53      55      56      