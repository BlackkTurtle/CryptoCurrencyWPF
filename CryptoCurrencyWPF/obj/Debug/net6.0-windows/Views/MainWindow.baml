   M S B A M L   `   `   `  ����L  HCryptoCurrencyWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CryptoCurrencyWPFCryptoCurrencyWPF  5   	   K*clr-namespace:CryptoCurrencyWPF.ViewModelsCryptoCurrencyWPF.ViewModels  67   b ^Microsoft.VisualBasic.Core, Version=11.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aaGclr-namespace:Microsoft.VisualBasic;assembly=Microsoft.VisualBasic.CoreMicrosoft.VisualBasic 6u   _4clr-namespace:CryptoCurrencyWPF.Properties.Languages&CryptoCurrencyWPF.Properties.Languages  5	   	   (    "CryptoCurrencyWPF.Views.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hi:http://schemas.microsoft.com/expression/2010/interactivity     5   	   1localclr-namespace:CryptoCurrencyWPF     5   	   A
viewmodels*clr-namespace:CryptoCurrencyWPF.ViewModels     67   aInteractivityGclr-namespace:Microsoft.VisualBasic;assembly=Microsoft.VisualBasic.Core     6u   RInteractivity19http://schemas.microsoft.com/netfx/2009/xaml/presentation    6�   Glanguage4clr-namespace:CryptoCurrencyWPF.Properties.Languages    5	   	   1   +CryptoCurrencyWPF.Properties.Languages.Lang    
mainWindow � Title# Z  5
   	   $
��1080��65   $
��1920��6C    � WindowState$ 	Maximized=�5   	   .��5      � $��0,0,0,-6q�6   $
��1920��6   $
��1080��6*   ���#b0b3b8.+�5   
   �� -   5         ��Name$ 	TextBlock��5      $
��Left=�6'   $��1437,400,0,0q�6B   $
��Wrap=�6X   $	��Top=�6l   $	��116��6�   $	��128��6�   � 5   
   $
��Left=�6   $
��1070��6*   $	��Top=�68   $	��366��6P   ���#323233.+�5      �� $
��Home��6   $��0,56,0,0q�6#   $	��Top=�65   $��48(�6M   $��Center=�6[   $	��168��6x   $��74��6�   ���	#FFB947476�   �� 5      -   5         ��Name$ ButtonConvertCurrencies��5      $��Convert Currency��66   $��Center=�6Q   $��44��6n   $��	0,187,0,0q�6z   $	��Top=�6�   $	��346��6�   $��18(�6�   ��6�   �� *OpenConvertCurrenciesWnd+5      �� 5   
   $��386,10,10,1000q�6   ���#323233
���   �$��1,1,1,1q�6R    �� CornerRadius$ 15,15,15,15��6l   ._�5      � $��Center=�6   $��81��60   $��0,-1,0,0q�6<   $	��Top=�6N   $
��1524��6f   .+�5      �� -   5         ��Name$ TextBoxSearch��5      $
��Left=�61   $��
55,13,0,22q�6L    �� TextWrapping$
 Wrap=�6`   $	��194��6t   $��20(�6�   ��6�   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�.��6�   	 J� InputBindings	 5      �� 5      

 �� Key$
 Enter��6T    �� Command 6%   ��  �� Path$ TextBoxSearchOnUpdate�6T   .��5   -   5      �� 5      -   5        $ ButtonSettings��5      $��Settings��61   $
��Left=�6D   $��26��6_   $��1422,21,0,0q�6k   $	��Top=�6�   $��76��6�   $��16(�6�   
����������	#FF888888��6�   �� *OpenSettingssWnd+6�   5      5      �� 5   
   -   5         ��Name$ ViewAllAssets��5   6   $��25(�6   ���#b0b3b8$
��Left=�6M   $	��972��6h   $��
366,98,0,0q�6u   $	��Top=�6�   $
��1554��6�    �� SelectionMode$ Single=�6�   
���   ���6�   �� *	AllAssets+ �� SelectedItem 6�   �� *SelectedAssets+ �� View 5      �� 5      .P�5      ��  �� Width$	 380��6%   $��Name:��61    �� DisplayMemberBinding 5    -   �� $
 name��� 5!      $	 380��6%   $��Rank:��61    5"   -   �� $
 rank��� 5#      $	 380��6%   $��Symbol:��61    5$   -   �� $ symbol��� 5%      $	 380��6%   $��
Price USD:��61    5&   -   �� $ priceUsd�5'      5)      5*      5+      