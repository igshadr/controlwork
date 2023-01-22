//Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

using System;

Console.WriteLine("Введите через запятую строки формируемого массива:");
//примеры для ввода с клавиатуры
//Hello,2,world,:-)
//1234,1567,-2,computer science
//Russia,Denmark,Kazan

string? text=Console.ReadLine();
if(!string.IsNullOrEmpty(text))
{
      string[] arr={};
      arr=text.Split(',');
      //вывод массива на экран
      Console.Write($"Ввели массив: ");
      PrintArr(arr); 
   
      //формирование нового массива из строк длиной <=3 символов
      string[] arrnew={};
      CreateNewArray(ref arr, ref arrnew);

      //вывод результата на экран
      Console.Write($"Новый массив: ");
      PrintArr(arrnew);
}
else
      Console.WriteLine("Введена пустая строка.");


//дополнительные функции
//печать массива
void PrintArr(string[] a)
{
      if(a.Length>=0)
            Console.Write($"[ ");
      
      for(int i=0;i<a.Length;i++)
      {
            Console.Write($"\"{a[i]}\" ");
            if(i<a.Length-1)
                  Console.Write($", ");
      }
      
      if(a.Length>=0)
            Console.WriteLine($"]");
}

//формирование нового массива
void CreateNewArray(ref string[] s, ref string[] snew)
{
      for(int i=0;i<s.Length;i++)
      {
            if(s[i].Length<=3)
            {
                  Array.Resize(ref snew, snew.Length+1);
                  snew[snew.Length-1]=s[i];
            }
      }
}