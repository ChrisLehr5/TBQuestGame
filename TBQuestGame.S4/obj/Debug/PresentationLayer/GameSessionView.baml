   M S B A M L   `   `   `  ����F  BTBQuestGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TBQuestGame.PresentationLayerTBQuestGame.PresentationLayer  5   	   3    -TBQuestGame.PresentationLayer.GameSessionView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:TBQuestGame.PresentationLayer     5   	   
�������$
��1000��5	   	   $	��600��5
   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$ SingleBorderWindow=�5   	    � 	Resources 5         BooleanToVisibility  GrayBlueGradientBrush �� 
StartPoint �� EndPoint �� Opacity � Color � Offset  BorderStyle �� 
TargetType	 �� Property
 �� Value  MainPanelLabelStyle  MainPanelButtonStyle �� 
TargetType ��Name �� RadiusX �� RadiusY ��Name �� Triggers P� Property P� Value �� Color  MainPanelTextBoxStyle ��Name �� CornerRadius ��Name��%�  &	        &	      &	 -    &	 �    &	 E    &	 �    �� 5   
   6'   �� 5   
   $	 0,0&�5      $	 1,0&�5      $ 50Q�5      .��5      � $ MidnightBlue��6   $ 0Q�60   � 5      $ #CCCCFF��6   $
 0.25Q�6+   � 5      $ #CCCCFF��6   $
 0.75Q�6+   � 5      $ MidnightBlue��6   $ 1Q�60   5      �� 5   
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

 �p�6+   �� 5O      	 � ��$	
 100��6&   �� 5P      	 � ��$
 20��6'   �� 5Q      	 � ��$
 3,0,0,0q�6(   �� 5R      	 � ��$
 Center=�62   �� 5S      	 � ��

 �����6+   �� 5T      	 � ��
 5U      �� 5V      .R�5W      �� $ Bd��5Y      #��z��5X      
���   �#��z��5[      $ 5��5\      ._�5]      �� $ PART_ContentHost��6+   5^      5_      5a      5b      5c      .��5d      � .+�5e   
   �� $��10q�5f      #��[ 5g      ._�5h      � $��10q�5i       � RowDefinitions 5j      �� 5k      $��3* �6$   �� 5l      $��1* �6$    � ColumnDefinitions 5n      �� 5o      $��1* �6'   �� 5p      $��2* �6'   �� 5q      $��1* �6'   .+�5s      �� $��0��5t      $��0��5u      $��0,0,0,10q�5v      #��[ 5w      ._�5x      �� .+�5y      �� $��Center=�5{      #��[ 5|      ��5z      �� *MissionTimeDisplay+5|      �� 5}       �� Orientation$ Vertical=�5~      $��50��5      6-   �� 5�      $��Current Location��5�      $��Center=�5�      #��[ 5�      �� 5�      $	��175��5�      $��10q�5�      #��[ 5�      $��Center=�5�      
���������5�      �� *CurrentLocation.Name+ �� Mode$ OneWay=�5�      �� 5�      $��Center=�5�      $��Center=�5�      #��[ 5�      �� 5�      $ 
Horizontal=�5�   !   $
��Left=�5�   !   $��0,5,10,0q�5�   !   .+�5�      �� -   5        $��50��5�   %   $��North��5�   %   #��[ 5�   %   5�   %   �� 5�      $	��125��5�   %   #��[ 5�   %   ��5�   %   �� *NorthLocation.Name+$ OneWay=�y�5�   %   �� *HasNorthLocation+ �� 	Converter# [  5�   %   5�      �� 5�      $ 
Horizontal=�5�   !   $
��Left=�5�   !   $��0,5,10,0q�5�   !   .+�5�      �� -   5        $��50��5�   %   $
��East��5�   %   #��[ 5�   %   5�   %   �� 5�      $	��125��5�   %   #��[ 5�   %   ��5�   %   �� *EastLocation.Name+$ OneWay=�y�5�   %   �� *HasEastLocation+# [  5�   %   5�      �� 5�      $ 
Horizontal=�5�   !   $
��Left=�5�   !   $��0,5,10,0q�5�   !   .+�5�      �� -   5        $��50��5�   %   $��South��5�   %   #��[ 5�   %   5�   %   �� 5�      $	��125��5�   %   #��[ 5�   %   ��5�   %   �� *SouthLocation.Name+$ OneWay=�y�5�   %   �� *HasSouthLocation+# [  5�   %   5�      �� 5�      $ 
Horizontal=�5�   !   $
��Left=�5�   !   $��0,5,10,0q�5�   !   .+�5�      �� -   5        $��50��5�   %   $
��West��5�   %   #��[ 5�   %   5�   %   �� 5�      $	��125��5�   %   #��[ 5�   %   ��5�   %   �� *WestLocation.Name+$ OneWay=�y�5�   %   �� *HasWestLocation+# [  5�   %   5�      �� 5�      $ Vertical=�5�      $��50��5�      �� 5�      $ Vertical=�5�      $	��100��5�      .+�5�      �� $ 
Horizontal=�5�      $��10q�5�      .+�5�   "   �� -   5        $��	Save Game��5�   !   #��[ 5�   !   5�   !   �� 5�   "   -   5        $��	Quit Game��5�   !   #��[ 5�   !   5�   !   5�      �� 5�      $ Vertical=�5�      $��50��5�      .+�5�   "   �� -   5        $��
About Game��5�   !   #��[ 5�   !   5�   !   5�      5�      �� 5�      $ Vertical=�5�      5�      5�      5�      �� 5�      $��0��5�      $��1��5�      $��
10,0,10,10q�5�      #��[ 5�      ._�5�      �  5�      �� 5�      $��4* �6,   �� 5�      $��1* �6,   .+�5�      �� $��0��5�      $ Vertical=�5�      .+�5�      �� $ Vertical=�5�   !   $��Center=�5�   !   $��0q�5   !   .+�5  "   �� $"��Current Location Information��5  )   $��Center=�5  )   #��[ 5  )   �� 5  "   $��1��5  %   $��0,0,0,5q�5  %    �� Padding$ 0q�5  %   
�������#��[ 5
  %   ._�5  &   �� $	��100��5  )   $	��350��5  )   $��10q�5  )   
�������$��0q�5  )    �� TextWrapping$
 Wrap=�5  )   " �� VerticalScrollBarVisibility$
 Auto=�5  )   $	��top=�5  )   #��[ 5  )   ��5  )   �� *CurrentLocationInformation+$ OneWay=�5  )   5  #   �� 5  "   -   5         ��Name$ LocationInfoTabControl��5  %   $	��350��5  %   .@�5  &   �� -	   5          ��Name$  ItemsInfoTabItem��5  )   $��Items��5  .   .��5  *   &   System.Windows.Controls.DataGrid  -
   5        !  Name$! LocationItemsDataGrid��5  -   $	��150��5  -   "   AutoGenerateColumns" .  #   HeadersVisibility$# Column=�5#  -   ��5   -   �� *CurrentLocation.GameItems+$ �� SelectedItem$ 5!  -   �� *CurrentGameItem+%   Columns% 5$  .   0  *System.Windows.Controls.DataGridTextColumn  5%  2   ,  &System.Windows.Controls.DataGridColumn&   Header$& Description��5&  5   '   
IsReadOnly' . (   Width5  /System.Windows.Controls.DataGridLengthConverter$( * 5)  5   1  +System.Windows.Controls.DataGridBoundColumn)   Binding) 5(  5   �� *GameItem.Information+$ OneWay=�*   ElementStyle* 5*  6   �� 5+  :   .�5,  >   �� 	 � ��$

 Wrap=�6g   5-  ;   5/  3     50  2   $	& Qty��51  5   ' . $
( Auto 53  5   ) 54  5   �� *
Quantity+$ OneWay=�56  +   57  '   �� 58  &   -   5        $  NpcsInfoTabItem��59  )   $
��NPCs��58  .   .��5:  *     -   5        $! LocationNpcsDataGrid��5;  -   $	��150��5<  -   " .  $# Column=�5@  -   ��5=  -   �� *CurrentLocation.Npcs+$ 5>  -   �� *
CurrentNpc+% 5A  .     5B  2   $& Description��5C  5   ' . $( * 5F  5   ) 5E  5   �� *Information+$ OneWay=�* 5G  6   �� 5H  :   .�5I  >   �� 	 � ��$

 Wrap=�6g   5J  ;   5L  3   5N  +   5O  '   5Q  #   5R     5S     �� 5T     $��1��5U     $ 
Horizontal=�5V     .+�5W     �� -   5        $��Speak To��5X  !   #��[ 5Y  !   5Z  !   �� 5[     $ 
Horizontal=�5\  !   $��5q�5]  !   .+�5^  "   �� -   5        $��Attack��5_  !   #��[ 5`  !   5a  !   �� 5b  "   -   5        $��0,3,0,3q�5c  !   $��Defend��5d  !   #��[ 5e  !   5f  !   �� 5g  "   -   5        $��Retreat��5h  !   #��[ 5i  !   5j  !   5k     5l     5n     5o     �� 5p     $��0��5q     $��2��5r     $��0,0,0,10q�5s     #��[ 5t     ._�5u     �� $ Vertical=�5v     .+�5w     �� $��	Inventory��5x     $��Center=�5y     $��Center=�5z     #��[ 5{     �� 5|     -   5        $ PlayerDataTabControl��5}     $
��auto��5~     $��10q�5     .@�5�     �� -   5        $  RelicsTabItem��5�  !   $
��Keys��5�  &   .��5�  "     -   5        $! KeysDataGrid��5�  %   " .  $# Column=�5�  %   ��5�  %   �� *Player.Keys+$ 5�  %   �� *CurrentGameItem+% 5�  &     5�  *   $
& Name��6=   $( * 5�  1   ) 5�  1   �� *GameItem.Name+$ OneWay=�5�  1     5�  *   $	& Qty��6=   ' . $
( Auto 5�  1   ) 5�  1   �� *
Quantity+$ OneWay=�  5�  *   $& Value��6=   $
( Auto 5�  1   ) 5�  1   �� *GameItem.Value+$ OneWay=�5�  1   5�  #   5�     �� 5�     -   5        $  WeaponsTabItem��5�  !   $��Weapons��5�  &   .��5�  "     -   5        $! WeaponsDataGrid��5�  %   " .  $# Column=�5�  %   ��5�  %   �� *Player.Weapons+$ 5�  %   �� *CurrentGameItem+% 5�  &     5�  *   $
& Name��6=   $( * 5�  1   ) 5�  1   �� *GameItem.Name+$ OneWay=�5�  1     5�  *   $	& Qty��6=   ' . $
( Auto 5�  1   ) 5�  1   �� *
Quantity+$ OneWay=�  5�  *   $& Value��6=   $
( Auto 5�  1   ) 5�  1   �� *GameItem.Value+$ OneWay=�5�  1   5�  #   5�     �� 5�     -   5        $  TreasureTabItem��5�  !   $��Treasure��5�  &   .��5�  "     -   5        $! TreasureDataGrid��5�  %   " .  $# Column=�5�  %   ��5�  %   �� *Player.Treasure+$ 5�  %   �� *CurrentGameItem+% 5�  &     5�  *   $
& Name��6=   $( * 5�  1   ) 5�  1   �� *GameItem.Name+$ OneWay=�5�  1     5�  *   $	& Qty��6=   ' . $
( Auto 5�  1   ) 5�  1   �� *
Quantity+$ OneWay=�  5�  *   $& Value��6=   $
( Auto 5�  1   ) 5�  1   �� *GameItem.Value+$ OneWay=�5�  1   5�  #   5�     �� 5�     -   5        $  PotionsTabItem��5�  !   $��Potions��5�  &   .��5�  "     -   5        $! PotionsDataGrid��5�  %   " .  $# Column=�5�  %   ��5�  %   �� *Player.Potions+$ 5�  %   �� *CurrentGameItem+% 5�  &     5�  *   $
& Name��6=   $( * 5�  1   ) 5�  1   �� *GameItem.Name+$ OneWay=�5�  1     5�  *   $	& Qty��6=   ' . $
( Auto 5�  1   ) 5�  1   �� *
Quantity+$ OneWay=�  5�  *   $& Value��6=   $
( Auto 5�  1   ) 5�  1   �� *GameItem.Value+$ OneWay=�5�  1   5�  #   5�     5�     �� 5�     $ 
Horizontal=�5�  !   $��Center=�5�  !   .+�5�     �� $��Holding��6$   #��[ 66   �� 5�     #��[ 6U   ��6&   �� *CurrentGameItem.GameItem.Name+6U   5�     �� 5�     $ Vertical=�5�     $��50��5�     �� 5�     $ 
Horizontal=�5�     $��10q�5�     .+�5�     �� -   5        $��Pick Up��5�  !   #��[ 5�  !   5�  !   �� 5�     -   5        $��Put Down��5�  !   #��[ 5�  !   5�  !   5�     �� 5�     $ 
Horizontal=�5�     $��10q�5�     .+�5�     �� -   5        $	��Use��5�  !   #��[ 5�  !   5�  !   �� 5�     -   5        $��Inspect Item��5�  !   #��[ 5�  !   5�  !   5�     5      5     �� 5     $��1��5     $��3��5     #��[ 5     ._�5     � $��5q�5      5     �� 5	     $��* �6/   �� 5
     $��2* �6/   �� 5     $��* �6/   .+�5     �� $��0��5     $ Vertical=�5     .+�5     �� $ Vertical=�5     $��30��5     .+�5  "   �� $��Character Information��5  !   $��Center=�5  !   $��Center=�5  !   #��[ 5  !   5     �� 5     $ 
Horizontal=�5  !   $
��Left=�5  !   .+�5  "   �� -   5        $��textBox1��5  Y   + �� 
IsReadOnly+ . #��[ 6i   ��6*   �� *Player.Name+6i   �� 5  "   $
��Name��6(   #��[ 67   5     �� 5     $ 
Horizontal=�5   !   $
��Left=�5!  !   .+�5"  "   �� -   5        $��textBox2��5"  Z   + . #��[ 6j   ��6*   �� *Player.Trait+6j   �� 5#  "   $��Trait��6(   #��[ 68   5$     �� 5%     $ 
Horizontal=�5&  !   $
��Left=�5'  !   .+�5(  "   �� -    5        $��textBox3��5(  X   + . #��[ 6h   ��6*   �� *
Player.Age+6h   �� 5)  "   $	��Age��6(   #��[ 66   5*     �� 5+     $ 
Horizontal=�5,  !   $
��Left=�5-  !   .+�5.  "   �� -!   5        $��textBox4��5.  ^   + . #��[ 6n   ��6*   �� *Player.PlayStyle+6n   �� 5/  "   $��
Play Style��6(   #��[ 6=   50     51     �� 52     $��1��53     $ Vertical=�54     .+�55     �� $��Log Book��56  !   $��Center=�57  !   $��Center=�58  !   #��[ 59  !   �� 5:     $��1q�5;     $ 0q�5<     
�������#��[ 5>     ._�5?  "   �� $��70��5@  !   $
��auto��5A  !   $��10q�5B  !   
�������$��0q�5D  !   $
 Wrap=�5E  !   $
 Auto=�5G  !   $	��top=�5H  !   #��[ 5I  !   ��5F  !   �� *MessageDisplay+$ OneWay=�5I  !   5J     5K     �� 5N     $��2��5O     $ Vertical=�5P     .+�5Q     �� $ Vertical=�5R     $��35��5S     6-   �� 5T     $ 
Horizontal=�5U  !   $��Right=�5V  !   .+�5W  "   �� -"   5        $��textBox5��5W  9   $��Health��6(   #��[ 6I   �� 5X  "   #��[ 6I   ��6*   �� *Player.Health+6I   5Y     �� 5Z     $ 
Horizontal=�5[  !   $��Right=�5\  !   .+�5]  "   �� -#   5        $��textBox6��5]  8   $��Lives��6(   #��[ 6H   �� 5^  "   #��[ 6H   ��6*   �� *Player.Lives+6H   5_     �� 5`     $ 
Horizontal=�5a  !   $��Right=�5b  !   .+�5c  "   �� -$   5        $��textBox7��5c  =   $��
Experience��6(   #��[ 6M   �� 5d  "   #��[ 6S   ��6*   �� *Player.ExperiencePoints+6S   5e     5f     5g     5h     5i     5j     5k     5l     