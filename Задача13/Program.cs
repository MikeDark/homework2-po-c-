//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

 Console.WriteLine("введите число ");
int number = Convert.ToInt32(Console.ReadLine());

 if (number > 99)
 {
     string number1 = "";
     number1 = Convert.ToString(number);
     Console.WriteLine(number1[2]);
 }
 else
 {
     Console.WriteLine("This number is not have thirdiget");
 }
