   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.PagesWpfApp1.Pages  5      $    WpfApp1.Pages.MaterialInfoPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Pages     5        N� Title$  MaterialInfoPage��5	      .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $ ��Идентификатор��6   $��0��6)   $��Center=�66   $��Center=�6Q   $��25(�6n   $��Times New Roman)�6|   �� 5   
   $��Наименование��6   $��1��6(   $��Center=�65   $��Center=�6P   $��25(�6m   $��Times New Roman)�6{   �� 5   
   $��Поставщик��6   $��2��6%   $��Center=�62   $��Center=�6M   $��25(�6j   $��Times New Roman)�6x   �� 5   
   $��Цена��6   $��3��6    $��Center=�6-   $��Center=�6H   $��25(�6e   $��Times New Roman)�6s   �� 5   
   -   5         ��Name$ LoadPhotoBtn��5      $!��Загрузить фото��6B   $��4��6[   $��0��6h   $��Center=�6x   $��Center=�6�   $��20 10q�6�      
additional#��[  6�   
�������6�   �� 5   
   $��1��6   $��0��6"   $��Center=�6K    �� 
IsReadOnly . $	��250��6x   ��6/   �� *
IdMaterial+6x   �� 5   
   $��1��6   $��1��6"   $��Center=�6E   $	��250��6`   ��6/   �� *Name+6`   �� 5   
   -   5        $��
SupplierCb��5       �� DisplayMemberPath$
 Name��6%   $��2��6`   $��1��6m   $	��250��6}   $��20��6�   $��Center=�6�    �� SelectedItem 6>   �� *
Supplier+6�   �� 5   
   $��1��6   $��3��6"   $��Center=�6F   $	��250��6a   ��6/   �� *Price+6a   �� 5    
   $��1��6   $��4��6    ��6-   �� *
GetPhoto+�� 5!   
   -   5        $ SaveBtn��5!      $��Сохранить��68   $��12��6L   $��2��6Z   #��[  6n   $��20 10q�6�   
�������$��Center=�6�   $��Center=�6�   5#      5$      