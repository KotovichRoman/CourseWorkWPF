   M S B A M L   `   `   `  ����W  SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType �� 
ResourceId �� TypeInTargetAssembly&    System.Windows.Controls.DataGrid �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �Name	 J� Opacity
 � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName #  Body_Content_DataGrid_Centering*  $System.Windows.Controls.DataGridCell  DataGridStyle �� Padding ��Name � ColumnDefinitions � RowDefinitions    SelectAllCommand7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!    HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name  �� ScrollableHeight! � Maximum" �� Orientation# �� ViewportHeight$ �� ViewportSize*% �� #ComputedVerticalScrollBarVisibility& � Value' �� Mode( �� ScrollableWidth) �� ViewportWidth,* �� %ComputedHorizontalScrollBarVisibility+ �� Triggers, ]� 
Conditions- �� Property. �� Value�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  (��       5      $" DataGridSelectAllButtonStyle��"   )&	  �    &	     �� 6   "  ��6{   .�5   
   ��  � �� 5      �� 5      " ��6"   .R�5      � .+�5      �� $ Border��6$   #��� ��64   $
 True��6u   � 5	      $ Arrow��6"   
���   �$��Right=�6>   $��8,8,3,3q�6Z   $	 0Q�6k   
 �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5
       5      P� 5       �@J�IsMouseOver$
 True��69   . �5      �� $ Border��67    � ��
 ���� 6K   5      P� 5       � ��$
 True��67   . �5      �� $ Border��65    � ��
 ���� 6I   5      P� 5       � {�$ False��67   . �5      �� $ Arrow��6;    � y�$ 	Collapsed=�6N   5      5      5      5      �� 5      "   5      .�5   
   ��  � ��$ Center=�5      5      �� 5      "    6"   .�5    
   ��  �@  GridLinesVisibility$
 None=�60   �� 5!   
    �@  RowBackground
 ���� 6*   �� 5"   
    � ��
 ���� 6'   �� 5#   
    � ��
 �����6'   �� 5$   
    � ��
 ���� 6(   �� 5%   
    � ��$ 1q�6,   �� 5&   
     �@  RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 5'   
    � ��$
 true��6:   �� 5(   
    �@��PanningMode$
 Both=�65   �� 5)   
    �@��IsFlicksEnabled$ False��63   �� 5*   
    �@  HeadersVisibility$ Column=�6.   �� 5+   
    � �� 5,      �� 5-      "   6"   .R�5.      �� #��z��6   #��z��6G   #��z��6s   # z��6�   $
 True��6�   ._�5/      �� $ DG_ScrollViewer��6'   $|�false��6@   ��50      �� 51   "   " ��62   .R�52   &   �  53   *   �� 54   .   $
��Auto �6?   �� 55   .   $��* �6?   �� 56   .   $
��Auto �6?    58   *   �� 59   .   $
��Auto �6<   �� 5:   .   $��* �6<   �� 5;   .   $
��Auto �6<   .+�5=   *   �� #��Z 61   $|�false��6`   ��6r   C� *�� $" DataGridSelectAllButtonStyle��"   +y�6�   �� *HeadersVisibility+# Z # Z  �� "   ��6�  �� *CellsPanelHorizontalOffset+ �� "     5>   *   $! PART_ColumnHeadersPresenter��6I   $��1��6n   y�6~   �� *HeadersVisibility+# Z # Z  �� "   �� 5?   *   $! PART_ScrollContentPresenter��6A   # z��6f   $��2��6�   $��1��6�   �� 5@   *   $ PART_VerticalScrollBar��64   $��2��6T   #! z  6d   $" Vertical=�6�   $��1��6�   #$ z# 6  #y�z% 6D  & 6�   �� *VerticalOffset+$' OneWay=� �� *TemplatedParent+6D  � 5A   *   $��1��6/   $��2��6?    5B   .   �� 5C   2   ��6C   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "   �� 5D   2   $��* �6C   .+�5F   .   �� $ PART_HorizontalScrollBar��68   $��1��6Z   #! z( 6j   $" 
Horizontal=�6�   #$ z) 6  #y�z* 6?  & 6�   �� *HorizontalOffset+$' OneWay=� �� *TemplatedParent+6?  5G   +   5H   '   5I   #   .��5K      �� # z 6-   5L      5M      5N      5P      + 5Q   
   ]� 5R      , 5S      �� 5T      - �@��
IsGrouping$
. true��66   �� 5U      "- �@%�IsVirtualizingWhenGrouping$. false��6X   ./�5W      ��  � ��$ false��6B   5X      5Z      5[      