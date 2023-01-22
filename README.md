## Задача:
Написать программу, которая из имеющегося массива строк  формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры массивов:
* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
* [“Russia”, “Denmark”, “Kazan”] → []

## Описание решения задачи:
*Программа* разработана на C# в Visual Studio Code (файл _Program.cs_). 

*Блок-схема алгоритма* работы программы реализована в сервисе [Program4you]https://programforyou.ru/block-diagram-redactor , представлена в файле _diagram.jpg_. 

*При разработке* программы был использова ручной ввод с клавиатуры символьных строк, разделённых запятыми, с последующим преобразованием строки в массив строк (использована функция _string.Split()_). С использованием подпрограммы _CreateNewArray(<первоначальный массив>,<итоговый массив>)_ первоначальный массив был поэлементно проанализирован на длину элементов менее или равных 3-м символам, из которых был сформирован новый массив. 

*При нахождении удовлетворяющих условию элементов первоначального массива размер нового массива увеличивался на 1 элемент, для чего была использована функция _Array.Resize()_. 

*Первоначальный и итоговый массивы были выведены на экран с использованием подпрограммы _PrintArr(<массив>)_.

*В процессе работы* проводилось сохранение версионности с использованием локального (_Git_) и удалённого репозиториев (_GitHub_).
