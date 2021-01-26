# course-work-computer-graphics
bmstu, IU7-7, Курсовой Проект по Комьютерной графике (2020)

Тема проекта: моделирование сцены, расположенной за прозрачной поверхностью. Для визуализации использовался прозрачный шар, внутри которого снеговик, но прозрачным может быть и любой другой объект.

Важно: программа будет работать некорректно, если внутри прозрачного объекта установить другой прозрачный объект и внутри него непрозрачный объект. Также у прозрачных объектов отсутствуют коэфф-ы преломления, т.е толщина прозрачной оболочки -> 0.

Программа поддерживает загрузку простых .obj моделей, которые можно получить в программе Paint 3D.

Также есть возможность текстурирования объектов, но оно происходит в однопоточном режиме из-за проблем с доступом к объекту типа Bitmap(это можно исправить при желании), трассировка без текстурирования поддерживает многопоточный режим, достигалось это за счет выгрузки информации из объекта типа Bitmap в массив битов и его дальнейшей обработки.

Есть поддержка мягких теней, для этого нужно установить на сцену дисковый объект, время рендера вырастет в разы, но тени получатся мягкими, более реалистичными.

Вся документация находится в папке doc.

Оценка: 5. Принимали Кузнецовы, скорее всего Куров найдет до чего доебаться, но я думаю даже для него курсач тянет на 4.
