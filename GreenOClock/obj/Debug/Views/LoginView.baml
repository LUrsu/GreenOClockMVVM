   M S B A M L   `   `   `  ����F  BGreenOClock, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null=#clr-namespace:GreenOClock.ViewModelGreenOClock.ViewModel  5   K   )clr-namespace:GreenOClockGreenOClock  6z   !    GreenOClock.Views.LoginView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2vm#clr-namespace:GreenOClock.ViewModel     6K   (ffclr-namespace:GreenOClock     6z     � 	Resources  5      *  $GreenOClock.ViewModel.LoginViewModel   LoginVm��%   &	          5   
   6   5	      .��5      �  � DataContext 6   ��  �� Source# [  ��5   
   �� 5       �� ImageSource$ plain-green-138.jpg��6   .+�5   
   �� -   5        $��stackPanel2��5   S   $
��auto��6   $
��Left=�6#   $��100,200,0,0q�6>   $	��Top=�6f   $	��289��6~   .+�5      � -   5        $��
wrapPanel1��5   &   $
��auto��6   $	��289��68   ���	#FF5E7C2D.+�5      �� -   5        $��label1��5   8   $��	User Name��6   $��28��6,   ���	#FFCEC645$��10q�6]   �� 5      -   5        $��textBox1��5   &   $��23��6   $	��180��66   
�������$��10q�6X   ��6d   �� *
UserName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5      -   5        $��label2��5   8   $��	Pass Word��6   $��28��6,   $��68��6F   ���	#FFCEC645$��10q�6h   �� 5      -   5        $��textBox2��5   &   $��23��6   $	��181��66   
�������$��10q�6X   ��6d   �� *
PassWord+$ TwoWay=�$ PropertyChanged=�5      �� 5      -   5        $��stackPanel1��5   '   $
��auto��6   $
��auto��6:    �� Orientation$ 
Horizontal=�6G   $��Right=�6`   .+�5      �� -   5        $��button2��5   k   ���	#FF91C239���	#FFFFEC18$��Register User��6G   $��23��6_   $��86��6z   ��6�   �� *RegisterUserCommand+�� 5      -	   5        $��button1��5   c   ���	#FF91C239���	#FFFFEC18$��Login��6G   $��23��6W   $��86��6r   ��6}   �� *LoginCommand+5      5      5       5!      