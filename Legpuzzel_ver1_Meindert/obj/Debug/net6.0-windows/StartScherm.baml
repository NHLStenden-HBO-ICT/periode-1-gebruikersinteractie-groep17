   M S B A M L   `   `   `  ����R  NLegpuzzel_ver1_Meindert, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Legpuzzel_ver1_MeindertLegpuzzel_ver1_Meindert  5   	   )    #Legpuzzel_ver1_Meindert.StartScherm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Legpuzzel_ver1_Meindert     5   	     � Title$  StartScherm��5   	   $	��450��6   $	��800��6*   .��5      � .+�5   
   �� ���#F5F5F56   �� 5   
   -   5         ��Name$
 LOGO��5      $��Center=�6   $	��100��6;   $��Center=�6I   $	��100��6d   $$��/Pictures/logo_carrot_gems.png��6p   �� 5   
   -   5        $��
MuziekKnop��5      $
��Left=�6#   $	��Top=�6>   $	��100��6V   $	��100��6c   
������    NoBugMusicOffStyle#��[  6�   �� 5   
   -   5        $��Geluidsknop��5      $
��Left=�6$   $	��Top=�6?   $��	0 100 0 0q�6W   $	��100��6j   $	��100��6w   
������   NoBugSoundOffStyle#��[ 6�   r� 5   
   -   5         r�Name$ mediaElement��5       r� Source$ muziek\De_muziek2.mp3?�6-    r� LoadedBehavior$ Manual=�6L   6e   r� 5   
   -   5        $ ButtonSound��5      $$ sounds\click-button-140881.mp3?�6,   $ Manual=�6T   6l   �� 5   
   -   5         ��Name$ 
ExitButton��5      $��Right=�6%   $	��Top=�6A   $	��100��6Y   $	��100��6f   
������   NoBugOffButtonStyle#��[ 6�   �� 5   
   -   5        $ StartButton��5      $��Start��6&   $��Center=�66   $��Center=�6S   $��60��6n   $	��170��6z   $��	0 250 0 0q�6�     Buttons#��[ 6�   5      5      