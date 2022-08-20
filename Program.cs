Console.Clear();
// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// // на выходе показывает вторую цифру этого числа.

// Console.Write(" Введите трехзначное число  -  ");
// int number = Convert.ToInt32(Console.ReadLine( ));
// int second = number/10 %10;
// if ( number < 100 || number > 999 ) 
// {
//    Console.Write("Число не трехзначное"); 
// }
// else
// {

// System.Console.WriteLine($" Вторая цифра в числе {number} -> {second}");
// //аналогично System.Console.WriteLine( second  );
// }

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// // или сообщает, что третьей цифры нет.

// Console.Write(" Введите число  -  ");
// int num = Convert.ToInt32(Console.ReadLine());
// // первый вариант не работает больше 2 миллиард.
// char[] array = Math.Abs(num).ToString().ToCharArray();
// Console.WriteLine(array.Length > 3 ? $"Третья цифра введенного числа: {array[2]}": "Третьей цифры нет");

////Второй вариант- мне понятнее!
// if (num < 0) 
// {
//     num = num * -1;
// }
// if (num > 0 && num < 100)
// {
//     Console.Write("Третьей цифры нет");
// }
// else 
// {
//     while (num > 999)
//     {
//         num = num/10;
//     }
//     int thirdNumber = num % 10;
//     Console.Write("Третья цифра   " + thirdNumber);
// }

// //третий вариант
// if(Math.Abs(num) < 100) //берем число по модулю (т.е.убираем минус, если отрицательное)
// {
// Console.Write("Третьей цифры нет");
// }
// else
// {
//       while(Math.Abs(num) >= 1000) //цикл,в кот.делим число на 10,до тех пор пока оно не станет 3х значным
//     {
//     num = num/10;
//     }
//     Console.Write(Math.Abs(num = num%10));
// }
// //Четвертое решение , счетчик/ Косяк если отрицательное число
// Console.WriteLine("Enter some number: ");
// int usersNumber = Convert.ToInt32(Console.ReadLine());
// int cycle = 0;
// while (cycle < usersNumber) 
//     {
//     if (usersNumber > 999)
//     usersNumber = usersNumber / 10;
//     cycle++;
//     }
// if (usersNumber > 99 && usersNumber < 1000)
// {
// Console.Write("The third digit is: ");
// Console.WriteLine(usersNumber % 10);
// }

// else
// {
// Console.WriteLine("There's no third digit in your number.");
// }

// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// // и проверяет, является ли этот день выходным.

// Console.Write("Введите номер дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
//первый вариант-длинный
// if (day < 1 || day > 7)
// {
// Console.Write("Неверное число. Потому что в неделе 7 дней");
// }
// else
//     if (day == 6 )
//     {
//      Console.Write("Это выходной день");
//     }
//     if (day == 7 )
//     {
//      Console.Write("Это выходной день");
//     }
//     if (day == 1 )
//     {
//      Console.Write("Это рабочий день");
//     }
//     if (day == 2 )
//     {
//      Console.Write("Это рабочий день");
//     }
//     if (day == 3 )
//     {
//      Console.Write("Это рабочий день");
//     }
//     if (day == 4 )
//     {
//      Console.Write("Это рабочий день");
//     }
//     if (day == 5 )
//     {
//      Console.Write("Это рабочий день");
//     }
// второй вариант !!
// if (day < 1 || day > 7)
// {
// Console.Write("Неверное число. Потому что в неделе 7 дней");
// }
// else

//      if (day > 5 )
//      {
//      Console.Write("Это выходной день"); 
//      }
//      else    
//      Console.Write("Это рабочий день");
