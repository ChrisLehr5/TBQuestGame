   M S B A M L   `   `   `  ����F  BTBQuestGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TBQuestGame.PresentationLayerTBQuestGame.PresentationLayer  5   	   5    /TBQuestGame.PresentationLayer.MissionStatusView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:TBQuestGame.PresentationLayer     5   	   
�������$
��1000��5	   	   $	��850��5
   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$ SingleBorderWindow=�5   	    � 	Resources 5         BooleanToVisibility  GrayBlueGradientBrush �� 
StartPoint �� EndPoint �� Opacity � Color � Offset  BorderStyle �� 
TargetType	 �� Property
 �� Value  MainPanelLabelStyle  MainPanelButtonStyle �� 
TargetType ��Name �� RadiusX �� RadiusY ��Name �� Triggers P� Property P� Value �� Color  MainPanelTextBoxStyle ��Name �� CornerRadius ��Name��%�  &	        &	      &	     &	 �    &	 5    &	 �    �� 5   
   6'   �� 5   
   $	 0,0&�5      $	 1,0&�5      $ 50Q�5      .��5      � $
 Gray��6   $ 0Q�6(   � 5      $ #CCCCFF��6   $
 0.25Q�6+   � 5      $ #CCCCFF��6   $
 0.75Q�6+   � 5      $
 Gray��6   $ 1Q�6(   5      �� 5   
   " ��6$   .�5      �� 	 � ��

 ����6,   �� 5      	 � ��$
 1q�60   �� 5      	 �@��CornerRadius$
 10��6-   5      �� 5   
   " ��6,   .�5      �� 	 � ��

 �����6+   �� 5       	 � ��$
 Lucida Console)�6+   5!      �� 5"   
   " ��6-   .�5#      �� 	 � ��$
 	10,0,10,0q�6'   �� 5$      	 � ��$
 75��6&   �� 5%      	 � ��$
 20��6'   �� 5&      	 � ��

 �����6+   �� 5'      	 � ��

 �p�6+   �� 5(      	 � ��
 5)      �� 5*      " ��6&   .R�5+      � #��z��5,      #��z��5-      }�. .+�5/      �� $ innerRectangle��50   !   $��Stretch=�51   !   $��Stretch=�52   !   #��z��53   !   $ 5��54   !   $ 5��55   !   ]� 57      $!��myContentPresenterDockPanel��6(   .+�58   "   �� $ myContentPresenter��59   %   $��2q�5:   %   $��Center=�5;   %   #��z��5<   %   
���   �5=   %   5>      5?      5@      5B       5C      P� 5D       �@J�IsMouseOver . . �5E      �� 	 � ��
 5F      �� 5G      $ LightSteelBlue��6.   5I      5J      5L      �� 5M   
   " ��6.   .�5N      �� 	 � ��

 �����6+   �� 5P      	 � ��$
 20��6'   �� 5Q      	 � ��$
 3,0,0,0q�6(   �� 5R      	 � ��$
 Center=�62   �� 5S      	 � ��

 �����6+   �� 5T      	 � ��
 5U      �� 5V      .R�5W      �� $ Bd��5Y      #��z��5X      
���   �#��z��5[      $ 5��5\      ._�5]      �� $ PART_ContentHost��6+   5^      5_      5a      5b      5c      .��5d      � .+�5e   
   �� $��10q�5f      #��[ 5g      ._�5h      � $��10q�5i       � ColumnDefinitions 5j      �� 5k      $��7* �6'   �� 5l      $	��63* �6'   �� 5m      $
��880* �6'    � RowDefinitions 5o      �� 5p      $	��150 �6$   �� 5q      $��2* �6$   .+�5s      �� $��0��5t      $��0q�5u      #��[ 5v      $��3��6:   ._�5w      � .+�5x      ��  �� Orientation$ Vertical=�5y      .+�5z      �� $ Vertical=�5{   !   $��Center=�5|   !   $��0q�5}   !   .+�5~   "   �� -   5        $��0,10,0,0q�5   %   $	��150��5�   %   $��Return to Main Screen��5�   %   #��[ 5�   %   5�   %   �� 5�   "   $��0q�5�   %   $��Quest Information��5�   %   $��Center=�5�   %   #��[ 5�   %   �� 5�   "   $��1��5�   %   $��0,0,0,5q�5�   %    �� Padding$ 0q�5�   %   
�������#��[ 5�   %   ._�5�   &   �� $��50��5�   )   $	��500��5�   )   $��10q�5�   )   
�������$��0q�5�   )    �� TextWrapping$
 Wrap=�5�   )    �� 
IsReadOnly . " �� VerticalScrollBarVisibility$
 Auto=�5�   )   $	��top=�5�   )   #��[ 5�   )   ��5�   )   �� *MissionInformation+ �� Mode$ OneWay=�5�   )   5�   #   5�      5�      5�      5�      �� 5�      #��[ 5�      $��0,10,0,0q�5�      $��1��5�      $��3��6"   ._�5�      �� .+�5�      &   System.Windows.Controls.DataGrid  -   5          Name$ LocationItemsDataGrid��5�      $	��500��5�      $��10q�5�          AutoGenerateColumns  .  !   HeadersVisibility$! Column=�5�      ��5�      �� *
Missions+"   Columns" 5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn#   Header$
# Name��5�   )   $   
IsReadOnly$ . %   Width5  /System.Windows.Controls.DataGridLengthConverter$	% 150 5�   )   1  +System.Windows.Controls.DataGridBoundColumn&   Binding& 5�   )   �� *Name+$ OneWay=�'   ElementStyle' 5�   &   �� 5�   *   .�5�   .   �� 	 � ��$

 Wrap=�6W   5�   +   5�   #     5�   "   $# Description��5�   )   $ . $	% 150 5�   )   & 5�   )   �� *Description+$ OneWay=�' 5�   &   �� 5�   *   .�5�   .   �� 	 � ��$

 Wrap=�6W   5�   +   5�   #     5�   "   $# Status��5�   )   $ . $	% 100 5�   )   & 5�   )   �� *Status+$ OneWay=�  5�   "   $# Details��5�   )   $ . $% * 5�   )   & 5�   )   �� *StatusDetail+$ OneWay=�' 5�   &   �� 5�   *   .�5�   .   �� 	 � ��$

 Wrap=�6W   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      