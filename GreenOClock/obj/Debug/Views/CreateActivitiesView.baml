   M S B A M L   `   `   `  ����F  BGreenOClock, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null=#clr-namespace:GreenOClock.ViewModelGreenOClock.ViewModel  5      ,    &GreenOClock.Views.CreateActivitiesView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2vm#clr-namespace:GreenOClock.ViewModel     5        � 	Resources  5      3   -GreenOClock.ViewModel.CreateActivityViewModel   	ViewModel(  "GreenOClock.ViewModel.TagConverter  TagToViewConverter4  .GreenOClock.ViewModel.SelectedTagViewConverter  SelectedTagToViewConverter��%W   &	        &	      &	 &       5	   
   6%     5
   
   6     5   
   6&   5      .��5      �  � DataContext 6   ��  �� Source# [  ��5   
   �� 5       �� ImageSource$ plain-green-138.jpg��6   .+�5   
   � $	��Top=�6   $
��auto��6'   $��Center=�5       � ColumnDefinitions 5      �� 5      $��* �6   $	��500��6)    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $��30 �6    .+�5      ��  �� Orientation$ Vertical=�6   $��0��60   $��Stretch=�6=   
�������.+�5       �� $��1. Name your new activity��6   
��� � �
�������$
��Bold"�6c    �� Padding$ 5q�6u   �� 5!      $��5q�5"      
���������5!      �� *NewActivityName+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�5"   !   5#      �� 5%      $ Vertical=�6   $��1��60   $��Stretch=�6=   .+�5(      � 
������� 5)      �� 5*      $��* �6+   �� 5+      $��* �6+    5-      �� 5.      $��30 �6(   �� 5/      $��* �6(   .+�53      �� $��Center=�6    $-��'2. Add tags that describe this activity��6;   $��2��6j   $ 5q�54      
��� � �
�������$
��Bold"�6N   �� 56      $ Vertical=�6!   $��Stretch=�68   $��0��6T   $��1��6d   .+�57      �� $��Your Remaining Tags��6    $��Center=�6>   $��18(�6[   $��Calibri)�6i   �� 59      -   5        
 ��Name$
 UnusedTagsListBox��59   "   $��Stretch=�6=    �� SelectionMode$ Single=�6b   $��Stretch=�5:      $	��310��65   $��0��6B   $��5q�6R   ���	#FF5E7C2D��5;      �� *UnUsedActivitiesTags+$	 PropertyChanged=� �� 	Converter# [ $ OneWay=� �� SelectedItem 5=      �� *UnUsedSellectedActivitiesTags+$ TwoWay=�$	 PropertyChanged=�# [ �� 5A      $��Add to Activity��6!   $��30��6;   $	��Top=�6G   $��0��6_   ���	#FF91C239���	#FFFFEC186�   5B      �� 5D      $ Vertical=�6!   $��1��68   $��1��6H   .+�5E      �� $��New Activity's Tags��6    $��Center=�6>   $��18(�6[   $��Calibri)�6i   �� 5G      -   5        $
 UsedTagsListBox��5G   "   $��Stretch=�6;   $ Single=�6`   $��Stretch=�5H      $	��310��65   $��0��6B   $��5q�6R   ���	#FF5E7C2D��5I      �� *UsedActivitiesTags+$	 PropertyChanged=�# [ $ OneWay=� 5K      �� *UsedSellectedActivitiesTags+$ TwoWay=�$	 PropertyChanged=�# [ �� 5N      $��Remove from Activity��6!   $��30��6@   $��1��6L   ���	#FF91C239���	#FFFFEC186s   5O      5Q      5R      �� 5T      $��Create New Activity��6   $
��auto��6X   $��2��6f   ���	#FF91C239���	#FFFFEC18$
��Bold"�5U   ?   ��5T   3   �� *RemoveTagCommand+5U   ?   5V      5X      5Y      