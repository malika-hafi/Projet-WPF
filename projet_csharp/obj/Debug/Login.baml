   M S B A M L   `   `   `  ����H  Dprojet_csharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:projet_csharpprojet_csharp  5          projet_csharp.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:projet_csharp     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  61   $	��645��5	   1   $
��1325��6>      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper N� 
Background# �  5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ Login��5      .��5      � 
�������.+�5   
   �� $�� ��6   $
��Left=�6   $��	414,0,0,0q�66   $	��Top=�6I   $	��645��6a   $	��901��6n   ��5      �� 5       �� ImageSource$F @Assets/inlytics-linkedin-analytics-tool-2SE1zwzeLOs-unsplash.jpg��6   5      �� 5   
   $��S'authentifier��6   $
��Left=�6)   $��	74,48,0,0q�6D   $	��Top=�6W   
������ $��30(�5   )   $��68��67   $	��335��6C   $
��Bold"�6O   �� 5   
   $%��Bienvenue dans note application��6   $
��Left=�6:   $��
74,100,0,0q�6U   $	��Top=�5      $��46��6(   $	��285��64   �� 5   
   $�� ��6   $
��Left=�6   $��
79,129,0,0q�66   $	��Top=�6J   $��5��6b    J� RenderTransformOrigin$ 0.5,0.5&�5      $��99��60   ���	#FF081D7Az�5      V� 5       .~�5!      ��  �� ScaleY$ -1Q�6%   �� 5"      �� 5#      T� 5$      5%      5'      � 5(   
   $
��Left=�6   $��42��6*   $��
74,216,0,0q�66   $	��Top=�6J   $	��335��6b    � RowDefinitions 5)      �� 5*      �� 5+      $	��38* �6    .+�5-      �� 	 �� Orientation$	 
Horizontal=�6   $
��Left=�62   $��39��6M   $��10,0,0,0q�6Y   $	��Top=�6k   $	��214��6�   $��2��6�   '  !MaterialDesignThemes.Wpf.PackIcon  5.      
   Kind$
 Account=�6'   $��41��66   $��41��6A   $��Bottom=�6�   $��	-16,0,0,0q�5/   &   ���	#FF257B95$��1��6Q   ��5.   M   ��  �� ElementName$
 User�� �� Path$ BorderBrush�5/   `   �� 50      -   5         ��Name$
 User��50      $��21(�6$   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Adresse Email��51       % !MaterialDesignFloatingHintTextBox#��[ 64   $��25,-14,10,3q�52      ���	#89163397$��2��6C   54      � 55   
   $
��Left=�6   $��39��6*   $��
74,333,0,0q�66   $	��Top=�6J   $	��234��6b    57      �� 58      $��5* �6    �� 59      $	��34* �6    �� 5:      $��2* �6    .+�5<      �� $	 
Horizontal=�6   $
��Left=�62   $��39��6M   $��10,0,0,0q�5=      $	��Top=�6+   $	��214��6C   $��2��6O     5>      $	
 Key=�6&   $��40��61   $��37��6<   $��Bottom=�5?   &   $��	-15,0,0,0q�5@   &   ���	#FF0B3989$��2��6Q   ��5>   H   �� $ Password��$ BorderBrush�5@   Q   G� 5B      -   5         G�Name$ Password��5C      $��21(�5B      $ Floating Password��5D       ) %MaterialDesignFloatingHintPasswordBox#��[ 5E      $��0,-18,-88,0q�6V   ���	#89103E9E$��2��6�   $��Right=�6�   $	��297��6�   �� 5F       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5G      $��416,-306,-340,263q�69   ���	#FF257B95���	#FF257B95$
��Auto��6�   .��6�   	Accueil5I      �� 5J      $/ )Resource name: MaterialDesignRaisedButton��5K      $��651,-306,-579,263q�69   ���	#FF257B95$
��Auto��6k   .��6y   	Contact5M      �� 5N      $/ )Resource name: MaterialDesignRaisedButton��5O      $��0,83,-76,-129q�6E   ���	#FF257B95���	#FF257B95$
��Auto��5P   )   $��Se Connecter��67   $��2��6N   $��5q�6[   5R      5T      �� 5U   
   $!��Vous n'avez pas de compte ?��6   $
��Left=�66   $��
74,550,0,0q�6Q   $	��Top=�5V      $��15(�6%   $��46��63   $	��298��6?   �� 5W   
     MaterialDesignFlatButton#��[ 5X      $ MaterialDesignFlatButton��5Z      $��268,534,935,55q�6(   $
��Auto��6@   $��20(�6N   .��6\   
S'inscrire5\      5]      5^      