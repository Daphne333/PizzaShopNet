   M S B A M L   `   `   `  ����I  EPizzaClientNew, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PizzaClientNewPizzaClientNew  5   	       PizzaClientNew.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:PizzaClientNew     5   	     � Title$  Login/Register��5   	   $	��221��6    $��343.121��6-   ���	#FFFAFAFA.��5	      �� $
��Left=�6   $	��306��6,   $��3,10,-234.2,-124.8q�69   $	��Top=�6U   $	��568��6m   .@�5
   
   �� -   5         ��Name$ Login��5
      $��Login��6!   .��5      � ���	#FFD9B76E$��0,0,207.6,106.2q�6*   .+�5      �� -   5         ��Name$ UsernameTextBox��5      $
��Left=�63   $��23��6N   $��
123,23,0,0q�6Z    �� TextWrapping$
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��174��6�   �� 5      $��Username��6   $
��Left=�6+   $��	18,23,0,0q�6F   $	��Top=�6Y   $��23��6q   $��69��6}    J� RenderTransformOrigin$ 0.246,0.583&�6�   �� 5      $��Password��6   $
��Left=�6+   $��	18,58,0,0q�6F   $	��Top=�6Y   �� 5      -   5         ��Name$ LoginButton��5      $��Login��6.   $
��Left=�6>   $��222,116,0,0q�6Y   $	��Top=�6n   $��75��6�   6�   �� 5      -   5         ��Name$ LoginErrorMessage��5      $��Customer not registered!��63   $
��Left=�6V   $��
155,87,0,0q�6q   $	��Top=�6�   
���  ��$y�Hidden=�6�   $ 0.996,-0.164&�6�   G� 5      -   5         G�Name$ PasswordBox��5      $
��Left=�63   $��
123,58,0,0q�6N   $	��Top=�6b   $	��174��6z   $��23��6�   5      5      �� 5   
   $��Register��6   ��5      �� 5       �� EndPoint$	 0,1&�6&   	 �� 
StartPoint$		 0,0&�65   .��5      � 
 � Color$
 	#FFF0F0F0��6#    � Offset$ 0Q�65   � 5      $
 White��6#   $ 1Q�61   5      .��5      � ���	#FFD9B76E$��0,0,224.6,119.2q�6*    � ColumnDefinitions 5      �� 5      .+�5      �� $��Username��6   $
��Left=�6+   $��	23,23,0,0q�6F   $	��Top=�6Y   $��23��6q   $��69��6}   �� 5       -   5        $ UsernameTextBoxRegister��5       $
��Left=�6;   $��23��6V   $��
123,23,0,0q�6b   $
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��174��6�   �� 5!      -   5        $ ErrorMessageRegister��5!      $�� ��66   $
��Left=�6A   $��	23,62,0,0q�6\   $	��Top=�6o   $y�Visible=�6�   $	��274��6�   �� 5"      -   5        $ RegisterButton��5"      $��Register��61   $
��Left=�6D   $��222,116,0,0q�6_   $	��Top=�6t   $��75��6�   6�   5#      5$      5%      5&      