   M S B A M L   `   `   `  ���� S  OParking-System-Simulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Parking_System_SimulatorParking_System_Simulator  )    #Parking_System_Simulator.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:Parking_System_Simulator       � Title$  
MainWindow��$	��720��$
��1280��$	��700��$
��1220��.���� ._�� ���#7E8285 � ColumnDefinitions �� $
��Auto ��� .+��� $��Images/Lines.png��$
��Fill=��� -   $��shadowLayer�����#000 J� Opacity$ .0Q� K� ZIndex$ 1�� J� IsHitTestVisible .  �� -   $��timeTB��$��12:00��
�������$��50(�$��10,0,0,0q�$
��Bold"� .  $ 2���  �� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* � � RowDefinitions �� �� $��1.21* ��� .+��� -   $��0��
������ 
������ $��8q�$��0��._��� -   $��A1Img��$
��Auto��$
��Auto��$��Uniform=�$��Center=�$��Center=� .  $��-40,0,-40,0q��� -   $��0��
������ 
������ $��8q�$��1��._��� -   $��A2Img��$
��Auto��$
��Auto��$��Uniform=�$��Center=�$��Center=� .  $��-40,0,-40,0q��� -   $��0��
������ 
������ $��8q�$��2��._��� -   $��A3Img��$
��Auto��$
��Auto��$��Uniform=�$��Center=�$��Center=� .  $��-40,0,-40,0q��� -	   $��0��
������ 
������ $��8q�$��3��._��� -
   $��A4Img��$
��Auto��$
��Auto��$��Uniform=�$��Center=�$��Center=� .  $��-40,0,-40,0q��� -   $��0��
������ 
������ $��8q�$��4��._��� -   $��A5Img��$
��Auto��$
��Auto��$��Uniform=�$��Center=�$��Center=� .  $��-40,0,-40,0q��� -   $��0��
������ 
������ $��8q�$��5��._��� -   $��A6Img��$
��Auto��$
��Auto��$��Uniform=�$��Center=�$��Center=� .  $��-40,0,-40,0q��� -   $��2��
������ 
������ $��8q�$��0��._��� -   $��B1Img��$
��Auto��$
��Auto��$��Uniform=� .  $��Center=�$��Center=�$��-40,0,-40,0q� J� RenderTransformOrigin$ .5, .52&�z���  �� ScaleY$ -1Q��� -   $��2��
������ 
������ $��8q�$��1��._��� -   $��B2Img��$
��Auto��$
��Auto��$��Uniform=� .  $��Center=�$��Center=�$��-40,0,-40,0q�$ .5, .52&�z��� $ -1Q��� -   $��2��
������ 
������ $��8q�$��2��._��� -   $��B3Img��$
��Auto��$
��Auto��$��Uniform=� .  $��Center=�$��Center=�$��-40,0,-40,0q�$ .5, .52&�z��� $ -1Q��� -   $��2��
������ 
������ $��8q�$��3��._��� -   $��B4Img��$
��Auto��$
��Auto��$��Uniform=� .  $��Center=�$��Center=�$��-40,0,-40,0q�$ .5, .52&�z��� $ -1Q��� -   $��2��
������ 
������ $��8q�$��4��._��� -   $��B5Img��$
��Auto��$
��Auto��$��Uniform=� .  $��Center=�$��Center=�$��-40,0,-40,0q�$ .5, .52&�z��� $ -1Q��� -   $��2��
������ 
������ $��8q�$��5��._��� -   $��B6Img��$
��Auto��$
��Auto��$��Uniform=� .  $��Center=�$��Center=�$��-40,0,-40,0q�$ .5, .52&�z��� $ -1Q�� $��1�����#272727 �� $��1* ��� $
��Auto ��� $
��Auto ��� $��2* ��� $
��Auto ��� $��1* �.+��� $��
0, 0, 0, 1q�$��	20,0,20,0q�
�������._��� $��Parking System Simulator��$��24(�$��Black"�$��	Open Sans)�
�������$��Center=�$��Center=��� $��
0, 0, 0, 1q�$��	20,0,20,0q�
�������$��1��._��� .+���  �� Orientation$ 
Horizontal=�$��Center=�.+��� -   $��
subHourBtn��$��25��$��50��$��
10,10,10,0q�
������ ���#223C46$��0q�.���� $��3��
������ $��0q����#223C46$��Marlett)�$
��Bold"�$��0,0,0,0q� .  $��
-20,-7,0,0q�$��25��$��50��$��70(��� -   $��subMinuteBtn��$��20��$��40��$��
10,10,10,0q�
������ ���#223C46$��0q�.���� $��3��
������ $��0q����#223C46$��Marlett)�$
��Bold"�$��0,0,0,0q� .  $��
-13,-4,0,0q�$��25��$��50��$��50(��� $
��🕑��$��40��$��40��   CircleButton#��[  ���#223C46���#BED6D9$��0q�$��Medium"�$��24(�$��0,0,0,3q�$��5,10,5,0q��� -   $��addMinuteBtn��$��20��$��40��$��
10,10,10,0q�
������ ���#223C46$��0q�.���� $��4��
������ $��0q����#223C46$��Marlett)�$
��Bold"�$��0,0,0,0q� .  $��
-20,-4,0,0q�$��25��$��50��$��50(��� -   $��
addHourBtn��$��25��$��50��$��
10,10,10,0q�
������ ���#223C46$��0q�.���� $��4��
������ $��0q����#223C46$��Marlett)�$
��Bold"�$��0,0,0,0q� .  $��
-28,-7,0,0q�$��25��$��50��$��70(��� $ 
Horizontal=�$��Center=�.+��� $	��-1h��$��45��$��0q�	 �� TextAlignment$	 Right=�$��0,0,0,10q�
������ ���#BED6D9$��Normal"�$��18(��� $
��-10m��$��50��$��0q�$	 Center=�
������ ���#BED6D9$��Normal"�$��18(�$��	10,0,0,10q��� $�� ��$��15��$��0q�$	 Center=�
������ ���#BED6D9$��Normal"�$��18(�$��	10,0,0,10q��� $
��+10m��$��50��$��0q�$	 Center=�
������ ���#BED6D9$��Normal"�$��18(�$��	10,0,0,10q��� $	��+1h��$��45��$��0q�$
	 Left=�
������ ���#BED6D9$��Normal"�$��18(�$��	10,0,0,10q��� $��
0, 0, 0, 1q�$��	20,0,20,0q�
�������$��2��._��� -   
 ��Name$
 	AddCarBtn��$��Add Car��$��24(�$
��Bold"�$��	Open Sans)����#BED6D9���#223C46$��0q�$��20q�$��48��  RoundButton#��[ $��2���� $��
0, 0, 0, 1q�$��	20,0,20,0q�
�������$��3��._��  �� �� $	��160 �.+��� .+��� -    $��selectCarTitle��$��Select a Car...�����#BED6D9$
��Bold"�$��0,20,0,0q� �� TextAlignment$ Center=�$��22(��  �� $
��Auto ��� $��1* �.+��� $��0��.+��� $��	Car Name:�����#BED6D9$��Normal"�$��0,10,0,0q�$��18(��� $��
Car Color:�����#BED6D9$��Normal"�$��0,10,0,0q�$��18(��� $��Parking Lane:�����#BED6D9$��Normal"�$��0,10,0,0q�$��18(��� $��Plate:�����#BED6D9$��Normal"�$��0,10,0,0q�$��18(��� $��1��.+��� -!   $��	carNameTB��$	��...�����#BED6D9$��Normal"�$��0,10,0,0q�$ Right=�$��18(��� -"   $��
carColorTB��$	��...�����#BED6D9$��Normal"�$��0,10,0,0q�$ Right=�$��18(��� -#   $��	carLaneTB��$	��...�����#BED6D9$��Normal"�$��0,10,0,0q�$ Right=�$��18(��� $��2��$��20,0,0,0q�.+��� $��1q�
�������._��� -$   $��carImage��$	��140��$	��160��$��Images/Audi.png��$��Uniform=�$
��Left=�$��Center=��� -%   $��
carPlateTB��$	��...�����#BED6D9$
��Bold"�$ Center=�$��18(�� $��4��$��0,5,0,0q� �� �� .+��� $��0��.+��� $��Entry Time:�����#BED6D9$��Normal"�$��	20,10,0,0q�$
 Left=�$��18(��� $��Elapsed Time:�����#BED6D9$��Normal"�$��	20,10,0,0q�$
 Left=�$��18(��� $��Current Cost:�����#BED6D9$��Normal"�$��	20,10,0,0q�$
 Left=�$��18(��� $��1��$��0,0,12,0q�.+��� -&   $��entryTimeTB��$	��...�����#BED6D9$��Normal"�$��	20,10,0,0q�$ Right=�$��18(��� -'   $��elapsedTimeTB��$	��...�����#BED6D9$��Normal"�$��	20,10,0,0q�$ Right=�$��18(��� -(   $��currentCostTB��$
��$...�����#BED6D9$��Normal"�$��	20,10,0,0q�$ Right=�$��18(��� -)   $��
paymentBtn��$��Pay and Leave��$��24(�$
��Bold"�$��	Open Sans)����#BED6D9���#223C46$��0q�$��20q�$��48��#��[ $��5��