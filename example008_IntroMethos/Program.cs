// Напишите программу, которая найдет максимум из 9ти чисел
// Вводим переменные 
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

//Введем новую переменную макс, в которую положим значение первого аргумента
int max =a1;

// Проверка на то, какое число больше
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

//Вывод на экран 
Console.WriteLine ("Max = " +max);