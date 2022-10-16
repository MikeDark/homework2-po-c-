// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 Console.WriteLine("Введите номер дня"); 
 int number = Convert.ToInt32(Console.ReadLine()); 
 if (number >= 1 && number <=5) 
 {
     Console.WriteLine("Рабочий день");
 }
 else if (number==6 || number ==7)
 {
     Console.WriteLine ("Выходной");
 }
 else 
 {
   Console.WriteLine("ошибка такого дня нет");
 }
