   M S B A M L   `   `   `  ����F  BGreenOClock, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null=#clr-namespace:GreenOClock.ViewModelGreenOClock.ViewModel  5   K   (    "GreenOClock.Views.RegisterUserView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2vm#clr-namespace:GreenOClock.ViewModel     6K     � 	Resources  5      1  +GreenOClock.ViewModel.RegisterUserViewModel   RegisterUserVm��%   &	          5	   
   6#   5
      .��5      �  � DataContext 6   ��  �� Source# [  ��5   
   �� 5       �� ImageSource$ plain-green-138.jpg��6   .+�5   
   �� -   5        $��stackPanel1��5   S   $
��auto��6   $
��Left=�6#   $��133,131,0,0q�6>   $	��Top=�6f   $	��275��6~   .+�5      � -   5        $��
wrapPanel1��5   &   $
��auto��6   $	��275��68   ���	#FF5E7C2D.+�5      �� -   5        $��label1��5   8   $��	User Name��6   $��28��6,   $��10q�6F   ���	#FFCEC6456R   �� 5      -   5        $��userName��5   &   $��23��6   $	��165��66   $��10q�6B   
���������6d   �� *
UserName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      -   5        $��label2��5   7   $��Password��6   $��28��6+   $��69��6E   $��10q�6P   ���	#FFCEC6456\   �� 5      -   5        $��textBox2��5   &   $��23��6   $	��165��66   $��10q�6B   
���������6d   �� *
PassWord+$ TwoWay=�$ PropertyChanged=��� 5      -   5        $��label3��5   4   $��Email��6   $��28��6(   $��69��6B   $��10q�6M   ���	#FFCEC6456Y   �� 5      -   5        $��email��5   &   $��23��6   $	��165��63   $��10q�6?   
���������6a   �� *Email+$ TwoWay=�$ PropertyChanged=�5      �� 5      -	   5        $��stackPanel2��5   '   $
��auto��6   $
��auto��6:   $��Right=�6G   .+�5      �� -
   5        $��register��5   8   $��Register��6   $��23��6,   $��75��6H   ���	#FF91C239���	#FFFFEC18��6S   �� *RegisterUserCommand+6�   5      5      5      5      