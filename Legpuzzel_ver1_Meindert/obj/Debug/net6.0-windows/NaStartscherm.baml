   M S B A M L   `   `   `  ����R  NLegpuzzel_ver1_Meindert, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Legpuzzel_ver1_MeindertLegpuzzel_ver1_Meindert  5   	   +    %Legpuzzel_ver1_Meindert.NaStartscherm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Legpuzzel_ver1_Meindert     5   	     � Title$  NaStartscherm��5   	   $	��450��6   $	��800��6,   .��5      � .+�5   
   �� -   5        $��
MuziekKnop��5      $��	0,100,0,0q�6#   $
��Left=�66   $	��Top=�6Q   $	��100��6i   $	��100��6v   
������    NoBugMusicOffStyle#��[  6�   �� 5   
   -   5        $��Geluidsknop��5      $��	0,200,0,0q�6$   $
��Left=�67   $	��Top=�6R   $	��100��6j   $	��100��6w   
������   NoBugSoundOffStyle#��[ 6�   r� 5   
   -   5         r�Name$ ButtonSound��5       r� Source$$ sounds\click-button-140881.mp3?�6,    r� LoadedBehavior$ Manual=�6T   6l   �� 5   
   $�� Naam Speler 1:��6   $
��Left=�6+   $��Center=�6F   $��30��6a   $	��135��6m   $	��150q�6y     
TextBlocks#��[ 6�   �� 5   
   $�� Naam Speler 2:��6   $��Right=�6+   $��Center=�6G   $��30��6b   $	��135��6n   $	��150q�6z   #��[ 6�   �� 5   
   -   5         ��Name$ txtPlayerName1��5      $��25��6*   $	��135��66   $
��Left=�6B   $��Center=�6]   $��
150 60 0 0q�6x   �� 5   
   -   5        $ txtPlayerName2��5      $��25��6*   $	��135��66   $��Right=�6B   $��Center=�6^   $��
0 60 150 0q�6y   �� 5   
   -   5         ��Name$ StartButton��5      $��Start��6&   $��Center=�66   $��Center=�6S   $��60��6n   $	��170��6z   $��	0 250 0 0q�6�     Buttons#��[ 6�   �� 5   
   -   5        $ 	BackArrow��5      $
��Left=�6$   $	��Top=�6?   $	��80 ��6W   $��80��6d     BackArrowStyle#��[ 6�   
������ 6�   �� 5   
   -   5        $ 
ExitButton��5      $��Right=�6%   $	��Top=�6A   $	��100��6Y   $	��100��6f   
������   NoBugOffButtonStyle#��[ 6�   5      5      