   M S B A M L   `   `   `  ���� C  ?TachyDev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TachyDev.ViewModelTachyDev.ViewModel  7 clr-namespace:TachyDev.ComponentTachyDev.Component  #    TachyDev.Component.Navigation   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /vm clr-namespace:TachyDev.ViewModel     2local clr-namespace:TachyDev.Component       � 	Resources   �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%%  '��       '�� �     �� " ��.���  � ��$ Stretch=���  � ��$ Stretch=���  � ��$ Center=���  � ��$ Center=���  � ��
 ���� ��  � ��$ 0q���  �@��SelectionMode$ Single=��� " ��.���  � ��
 �������  � ��$ 20(���  � ��$ Black"���  � ��$ 60����  � �� �� " ��.R��� #��z��._��� #��z��#��z�� P�  �@J�IsMouseOver$
 True�� ���  � ��
 � ���P�  �@��
IsSelected$
 True�� ���  � ��
 �������  � ��
 � ��� � DataContext %  TachyDev.ViewModel.NavigationVM  .���� 	 �� SelectedItem	 �� *PageSelection+.@��� .��	AUTHORIZE�� .��RESERVATIONS�� .��
ARRIVALS�� .��
DEPARTURES�� .��GUESTS�� .��ROOMS�� .��
STATISTICS