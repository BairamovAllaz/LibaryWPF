   M S B A M L   `   `   `  ����  
Libary.App(    "Libary.App.Windows.Main.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Libary��5   	   $	��450��5   	   $	��800��6    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5   	   ��  �� RelativeSource �� *Self+ � 	Resources 5       �� Source�� 5   
   $ MainWindowStyle.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� $��0��6   .+�5      �� -   5         ��Name$ 
SearchText��5      �� 5      -   5        	 ��Name$	 ListOfBooks��5         StyleDefault#��[  5      ��5      �� *Books+
 �� SelectedItem
 5      �� *Book+ �� View 5      �� 5      .P�5      �� $��Title��5   %    �� DisplayMemberBinding 5   %   �� *Title+5   %   �� 5       $��Author��5!   %    5    %   �� *Author+5!   %   5"      5$      5%      �� 5&   
   $��1��6   .+�5'      ��   StyleStackPanelLeft#��[ 6   .+�5(      �� $
��Name��6     
StyleLabel#��[ 5)      �� 5*      -   5        $ 
InputTitle��5*        
StyleInput#��[ 5+      ��5,      �� *
Book.Title+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�5-      �� 5.      #��[ 6   .+�5/      �� $��Author��6   #��[ 50      �� 51      -   5        $ InputAuthor��51      #��[ 52      ��53      �� *Book.Author+$ OneWay=�$ PropertyChanged=�54      �� 55      #��[ 6   .+�56      �� $��Genre��6   #��[ 57      �� 58      -   5        $ 
InputGenre��58      #��[ 59      ��5:      �� *
Book.Genre+$ OneWay=�$ PropertyChanged=�5;      �� 5<        StyleStackPanelCenter#��[ 6   .+�5=      �� -   5        $��Clear��5=        StyleButtonClear#��[ 5>      5?      �� 5@      -   5        $��Delete��5@        StyleButtonDelete#��[ 5A      5B      �� 5C      -   5        $
��Save��5C        StyleButtonSave#��[ 5D      5E      5F      5G      5H      5I      