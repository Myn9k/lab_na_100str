   M S B A M L   `   `   `  ����B  >Workers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Worker.ViewWorker.View  5   	        Worker.View.WindowEmployee   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Worker.View     5   	     � Title$  Сотрудники��5   	   $	��300��6   $	��500��6)   .��5	      �� .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   ���	#FFE4E0E0.+�5      �� -   5         ��Name$ btnAdd��5      $��
10,10,5,10q�6%   $��Добавить��69   $��25��6L   ��6X   �� *	AddPerson+�� 5      -   5        $ btnEdit��5      $��
10,10,5,10q�6&   $ ��Редактировать��6:   $��25��6R   ��6^   �� *
EditPerson+�� 5      -   5        $ 	btnDelete��5      $��
10,10,5,10q�6(   $��Удалить��6<   $��25��6N   ��6Z   �� *DeletePerson+5      �� 5   
   -   5         ��Name$ 
lvEmployee��5      ��6'   �� *ListPersonDpo+ �� View 5      �� 5      P�5      �� 5      $��Код��6)    �� Width$ 50��66    �� DisplayMemberBinding 6A   �� *Id+�� 5      $��Фамилия��6)    6:   �� *
LastName+�� 5      $��Имя��6)    66   �� *	FirstName+�� 5      $��Должность��6)    6<   �� *
RoleName+�� 5      $��Дата рождения��6)    6@   �� *
Birthday+ �� StringFormat$ {0:dd.}{0:MM.}{0:yyyy}��5      5      5      5      