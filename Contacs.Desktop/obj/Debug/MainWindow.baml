   M S B A M L   `   `   `  ����  Contacs.Desktop     Contacs.Desktop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � $��
12,12,12,0q�6    � 	Resources 5   
      
SearchHint j� Stretch j� 
AlignmentX j� 
AlignmentY �� 	Transform T� X T� Y !� Visual	 �� TextAlignment��%  &	        !� 5      $
 None=�6-   $
 Left=�6<   $	 Top=�6N    5      T� 5	      $ 4Q�6)   $ 7Q�6/    5      � 5      .+�5      �� $��Enter a user's alias��6$   $��Normal"�6@   
�������$��12(�5      $	 Justify=�6(   5      5      5      .+�5   
   �� $��0��6   $��5,5,5,0q�6"   $	��Top=�63   $	��295��6K   .+�5      �� -   5        $��1��5      $��Cargar Contactos��6%   $��Right=�6@   $��0,10,-0.2,0q�6\   $	��Top=�6q   $	��201��6�   
 J� RenderTransformOrigin$
 -0.013,0.15&�6�   $��34��6�    �� 	IsDefault . $��2��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ SearchResults��5      $��0,0,0,0q�6.      AutoGenerateColumns .  ��. $��Disabled=�6�      
IsReadOnly . $	��350��5         CanUserAddRows .     CanUserDeleteRows .  $	��180��6^      GridLinesVisibility$
 None=�6k   ���	#FFFFFFFF   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *	GivenName+6\     5      $ 	Last Name��6)   $ 1* 6Y    6<   �� *	Surname+6Y     5      $	 UPN��6)   $ 3* 6W    66   �� *DisplayName+6W     5      $ Phone��6)   $ 1* 6\    68   �� *BusinessPhone1+6\   5      5      5       5!      