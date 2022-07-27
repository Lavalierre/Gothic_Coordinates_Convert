# О программе
Данная программа предназначена для конвертации пикселей в виртуальные пиксели Готики.

Небольшая справка:
Виртуальные пиксели - это специальная метрика, которая позволяет измерять экран по осям X и Y не привязываясь к разрешению экрана.
Независимо от разрешения экрана пользователя, в каждую сторону оси могут принимать значения от 0 до 8192.

Для чего может быть полезна данная программа?
Вы можете заранее выстроить макет интерфейса в графическом редакторе (например Photoshop). Для этого в секцию "Разрешение экрана" введите фактическое разрешение
холста (в данном случае весь холст будет представлять собой экран, так что лучше изначально создавать его с правильным размером, например 1920x1080), после чего
вы можете вводить параметры каждого элементы (положение по оси X/Y, высоту (W) и ширину (H)) в графу "Входные координаты", и в графе "Выходные координаты" получать
точные значения в виртуальных координатах.

Имейте ввиду, что работа с текстом может быть с подвохом, т.к. игра сама скалирует размер текста автоматически.

![screenshot](https://i.imgur.com/GadQl1a.png)