   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      Y UTimeKeeper.GenericUserControls, Version=0.0.1.0, Culture=neutral, PublicKeyToken=nullwTclr-namespace:TimeKeeper.GenericUserControls;assembly=TimeKeeper.GenericUserControlsTimeKeeper.GenericUserControls 5      M ITimeKeeper-Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TimeKeeper_Desktop.UserControlsTimeKeeper_Desktop.UserControls 5      5   /TimeKeeper_Desktop.UserControls.DateTimeControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5      dgucTclr-namespace:TimeKeeper.GenericUserControls;assembly=TimeKeeper.GenericUserControls     5      ?local-clr-namespace:TimeKeeper_Desktop.UserControls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5	   	   -   5        6  0TimeKeeper.GenericUserControls.BaseTimeControl`1   Name$  DateTimeInstance��5       $
��Auto��6   $
��Auto��6   -  'System.Windows.Input.KeyboardNavigation   TabNavigation$ Local=�5      .��5      � -   5         �Name$ 
LayoutRoot��5      $
��Auto��6   $
��Auto��6)   $	��5,2q�67    � ColumnDefinitions 5      �� 5      $
��0.2* �6   �� 5      $��0.05* �6   �� 5      $
��0.2* �6   �� 5      $��0.05* �6   �� 5      $
��0.2* �6   .+�5      � -   5        $
 hour��5   	   .+�5       �� -   5         ��Name$ mmTxt��5        �� TextWrapping$
 Wrap=�6    �� TextAlignment$ Center=�6x   $��Center=�6�   $��Goudy Stout)�6�   $��14(�6�   ��60   ��  �� Path$ Hours� �� ElementName$ DateTimeInstance��	 �� Mode$	 Default=�6�   5!      � 5#      $��1��6
   .+�5$      �� -   5        
 ��Name$

 sep1��5$      $
��Wrap=�6   $��Center=�62   $��Goudy Stout)�6c   $��14(�6|   $��:��6�    �� TextAlignment$ Center=�6�   ��6M   Z� 6�   5%      � 5(      -   5        $	 min��5(   	   $��2��6   .+�5)      �� -   5        $ ddTxt��5)      $
 Wrap=�6   $ Center=�6|   $��Center=�6�   $��Goudy Stout)�6�   $��14(�6�   ��62   �� $ Minutes�$ DateTimeInstance��$	 Default=�6�   5*      � 5,      $��3��6
   .+�5-      �� -   5        $

 sep2��5-      $
��Wrap=�6   $��Center=�62   $��Goudy Stout)�6c   $��14(�6|   $��:��6�   $ Center=�6�   ��6M   Z� 6�   5.      � 51      -	   5        $	 sec��51   	   $��4��6   .+�52      �� -
   5        $ yyTxt��52      $
 Wrap=�6   $ Center=�6{   $��Center=�6�   $��Goudy Stout)�6�   $��14(�6�   ��61   �� $ Seconds�$ DateTimeInstance��$	 Default=�6�   53      55      57      