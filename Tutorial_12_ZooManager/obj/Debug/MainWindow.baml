   M S B A M L   `   `   `  ����Q  MTutorial_12_ZooManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Tutorial_12_ZooManagerTutorial_12_ZooManager  5   	   '    !Tutorial_12_ZooManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Tutorial_12_ZooManager     5   	     � Title$  
ZooManager��5   	   $	��430��6   $	��565��6)   .��5	      � .+�5
   
   �� $��Zooliste��6   $
��Left=�6#   $��	10,10,0,0q�6>   $	��Top=�6Q   $��70��6i   �� 5   
   -   5        $��lbxZooListe��5      $
��Left=�6%   $	��175��6p   $��	10,41,0,0q�6}   $	��Top=�6�   $	��150��6�   �� 5   
   $ ��Tiere in ausgewähltem Zoo��6   $
��Left=�64   $��
200,10,0,0q�6O   $	��Top=�6c   $	��160��6{   �� 5   
   -   5        $��lbxAssociatedAnimals��5      $
��Left=�6.   $	��175��6I   $��
200,41,0,0q�6V   $	��Top=�6j   $	��150��6�   �� 5   
   -   5        $��lbxAnimalListe��5      $
��Left=�6(   $	��299��6C   $��
390,41,0,0q�6P   $	��Top=�6d   $	��150��6|   6�   �� 5   
   -   5        $��tbAddZooOrAnimal��5      $
��Left=�6+   $��30��6F   $��
10,270,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��340��6�   �� 5   
   -   5        $��btZooDelete��5      $��Zoo löschen��6$   $
��Left=�6:   $��
10,230,0,0q�6U   $	��Top=�6i   $	��150��6�   $��30��6�   6�   �� 5   
   -   5        $��btAnimalRemove��5      $��Tier entfernen��6'   $
��Left=�6@   $��200,230,0,0q�6[   $	��Top=�6p   $	��150��6�   $��30��6�   6�   �� 5   
   -   5        $��btZooAdd��5      $��Zoo hinzufügen��6!   $
��Left=�6:   $��
10,310,0,0q�6U   $	��Top=�6i   $	��150��6�   $��30��6�   6�   �� 5   
   -   5        $��btZooUpdate��5      $��Zoo aktualisieren��6$   $
��Left=�6@   $��
10,350,0,0q�6[   $	��Top=�6o   $	��150��6�   $��30��6�   6�   �� 5   
   -	   5        $��btAnimalAdd��5      $��Tier hinzufügen��6$   $
��Left=�6>   $��200,310,0,0q�6Y   $	��Top=�6n   $	��150��6�   $��30��6�   6�   �� 5   
   -
   5        $��btAnimalUpdate��5      $��Tier aktualisieren��6'   $
��Left=�6D   $��200,350,0,0q�6_   $	��Top=�6t   $	��150��6�   $��30��6�   6�   �� 5   
   -   5        $��btAnimalDelete��5      $��Tier löschen��6'   $
��Left=�6>   $��390,350,0,0q�6Y   $	��Top=�6n   $	��150��6�   $��30��6�   6�   �� 5   
   -   5        $��btAnimalToZeeAdd��5      $��Tier zu Zoo hinzufügen��6)   $
��Left=�6J   $��	390,9,0,0q�6e   $	��Top=�6x   $	��150��6�   $��30��6�   6�   5      5      