   M S B A M L   `   `   `  ����G  CWow Anti Afk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Wow_Anti_AfkWow_Anti_Afk  5   	       Wow_Anti_Afk.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Wow_Anti_Afk     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��400��6)    � 
ResizeMode$ CanMinimize=�5	   	   ��5
      �� 5   
    �� ImageSource$ img/warlock1.jpg��6   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ Start_Anti_Afk��5      $��Start Anti Afk��6)   $
��Left=�6B   $��
10,102,0,0q�6]   $	��Top=�6q   $	��150��6�   $��35��6�   6�   �� 5   
   -   5        $ Start_Click��5      $��Auto Right Click��6&   $
��Left=�6A   $��26.8,102,0,0q�6\   $	��Top=�6r   $	��150��6�   $��35��6�   $��1��6�    �� IsCancel . 6�   �� 5   
   -   5        $ Stop_Anti_Afk��5      $��Stop Anti Afk��6(   $
��Left=�6@   $��
10,154,0,0q�6[   $	��Top=�6o   $	��150��6�   $��35��6�   6�   �� 5   
   -   5        $ 
Stop_Click��5      $��Stop Auto Click��6%   $
��Left=�6?   $��26.8,154,0,0q�6Z   $	��Top=�6p   $	��150��6�   $��35��6�   $��1��6�   6�   �� 5   
   $��WoW Anti Afk��6   $��Center=�6'   $	��Top=�6D   $��39��6\   $��228.8��6h   $.��(/Wow Anti Afk;component/Fonts/#LifeCraft)�6v   $��Center=�6�   $��Center=�6�   $��36(�6�    � UseLayoutRounding .  $��2��6  
���   �$��0,0,144.8,0q�6A   J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$	 0.5Q�6#   	   ShadowDepth$	 3Q�61   5      �� 5   
   $��& Auto Clicker��6   $
��Left=�6-   $��
0.2,62,0,0q�6H   $	��Top=�6\   $��35��6t   $	��177��6�   $��1��6�   $.��(/Wow Anti Afk;component/Fonts/#LifeCraft)�6�   $��22(�6�   $��Center=�6�   $��Italic$�6  
���  �� 5        5      $	 0.5Q�6#   $	 2Q�61   
   
BlurRadius$
 2Q�6A   5      5       5!      