   M S B A M L   `   `   `  ����L  HShaitanetDinar421, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ShaitanetDinar421.PagesShaitanetDinar421.Pages  5      -    'ShaitanetDinar421.Pages.ProductListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:ShaitanetDinar421.Pages     5        N� Title$  ProductListPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��64* �6   �� 5      $
��453* �6   �� 5      $	��43* �6    � ColumnDefinitions 5   
   �� 5      $
��171* �6   �� 5      $
��558* �6   �� 5      $
��181* �6   .+�5   
   �� $	��Top=�6   $��Center=�6-   $��1��6J   .+�5      �� -   5         ��Name$ 
ProductBtn��5      $	��150��6B   $��50��6N   $��0 0 0 20q�6Z   .��6l   
Корма6s   �� 5      -   5        $ UserBtn��5      $	��150��6<   $��50��6H   $��0 0 0 20q�6T   .��6f   Мой профиль6s   �� 5      -   5        $ ExitBtn��5      $	��150��6<   $��50��6H   $��0 0 0 20q�6T   .��6f   
Выход6m   5      �� 5   
   
���   �$��1q�6%   $��1��69   $��1��6F   ._�5      �� $
��Auto=�6   .��5       � -   5         �Name$ MyPanel��5       $��Center=�6-   6L   5!      5"      �� 5$   
   
���   �$��1q�6%   $��Right=�69   $��10q�6U   $	��150��6a   $��2��6m   $��1��6z   ._�5%      �� -   5         ��Name$ CountTb��5%       �� TextAlignment$ Right=�6)   $	��5 0q�6?   $��Center=�6L   6i   5&      �� 5(   
   -   5        $ AddBtn��5(      $	��100��66   $��1��6B   $��2��6R   $
��Left=�6_   .��6z   Добавить корм6�   �� 5*   
   $��1��6   $��2��6"   $��
15 15 15 0q�62   .+�5+      �� 
���   �$��1q�6)   $	��Top=�6=   $��25��6U   ._�5,      � .+�5-      �� -   5        $ SearchTextBlock��5-       $
��Left=�69   
Поиск6\   �� 5.      -   5         ��Name$ SearchTb��5.      
������ 6n   5/      50      �� 52       �� Orientation$ 
Horizontal=�6   $��Right=�62   $��0 30 0 0q�6N   .+�53      �� -	   5        	 ��Name$	 BackPage��53      $��/Resources/LeftArrow.png��6I   $��0 0 30 0q�6l   $��60��6~   �� 54      -
   5        $	 NextPage��54      $��/Resources/RightArrow.png��6I   $��60��6m   55      56      58      59      