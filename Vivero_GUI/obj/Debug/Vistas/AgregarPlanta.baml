   M S B A M L   `   `   `  ����E  AVivero_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Vivero_GUI.VistasVivero_GUI.Vistas  5   	   %    Vivero_GUI.Vistas.AgregarPlanta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Vivero_GUI.Vistas     5   	     � Title$  Agregar nueva planta��5   	   $	��450��6&   $	��800��63   .��5	      � .+�5
   
   �� $��Id��6   $
��Left=�6   $��
223,30,0,0q�68   $	��Top=�6L   �� 5   
   $��Nombre comun��6   $
��Left=�6'   $��
167,60,0,0q�6B   $	��Top=�6V   �� 5   
   $��Nombre cientifico��6   $
��Left=�6,   $��
156,90,0,0q�6G   $	��Top=�6[   �� 5   
   $��Tipo de planta��6   $
��Left=�6)   $��174,120,0,0q�6D   $	��Top=�6Y   �� 5   
   $��Descripcion��6   $
��Left=�6&   $��188,150,0,0q�6A   $	��Top=�6V   �� 5   
   $��Tiempo de riego��6   $
��Left=�6*   $��162,180,0,0q�6E   $	��Top=�6Z   �� 5   
   $��Cantidad de agua��6   $
��Left=�6+   $��162,210,0,0q�6F   $	��Top=�6[   �� 5   
   $��Epoca��6   $
��Left=�6    $��219,240,0,0q�6;   $	��Top=�6P   �� 5   
   $��Es venenosa��6   $
��Left=�6&   $��185,270,0,0q�6A   $	��Top=�6V   �� 5   
   $��Es autoctona��6   $
��Left=�6'   $��185,300,0,0q�6B   $	��Top=�6W   �� 5   
   -   5         ��Name$ txtId��5      $
��Left=�6"   $��
294,34,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6e   $	��294��6}   �� 5   
   -   5        $ txtNombreComun��5      $
��Left=�6*   $��
294,64,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��294��6�    �� 	MaxLength$	 100��5      ��5      �� *NombreComun+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  � ToolTip 5      �� *ErrorCollection[NombreComun]+�� 5   
   -   5        $ txtNombreCientifico��5      $
��Left=�6/   $��
294,94,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��294��6�   $	 150��5      ��5      �� *NombreCientifico+$ PropertyChanged=� .  5      �� *#!ErrorCollection[NombreCientifico]+�� 5   
   -   5        $ txtTipoPlanta��5      $
��Left=�6)   $��294,124,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��294��6�   ��5       �� *
TipoPlanta+$ PropertyChanged=� .  5!      �� *ErrorCollection[TipoPlanta]+�� 5#   
   -   5        $ txtDescripcion��5#      $
��Left=�6*   $��294,154,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��294��6�   ��5$      �� *Descripcion+$ PropertyChanged=� .  5%      �� *ErrorCollection[Descripcion]+�� 5'   
   -   5        $ txtTiempoRiego��5'      $
��Left=�6*   $��294,184,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��294��6�   ��5(      �� *TiempoRiego+$ PropertyChanged=� .  5)      �� *ErrorCollection[TiempoRiego]+�� 5+   
   -   5        $ txtCantidadAgua��5+      $
��Left=�6+   $��294,214,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��294��6�   ��5,      �� *CantidadAgua+$ PropertyChanged=� .  5-      �� *ErrorCollection[CantidadAgua]+�� 5/   
   -   5        $ txtEpoca��5/      $
��Left=�6$   $��294,244,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��294��6�   ��50      �� *Epoca+$ PropertyChanged=� .  51      �� *ErrorCollection[Epoca]+�� 52   
   -	   5         ��Name$ chkEsVenenosa��52      $�� ��6+   $
��Left=�66   $��294,276,0,0q�6Q   $	��Top=�6f   �� 53   
   -
   5        $ chkEsAutoctona��53      $�� ��6,   $
��Left=�67   $��294,305,0,0q�6R   $	��Top=�6g   �� 54   
   -   5         ��Name$ btnAgregarPlanta��54      $��Agregar planta��6+   $
��Left=�6D   $��400,350,0,0q�6_   $	��Top=�6t   6�   55      56      