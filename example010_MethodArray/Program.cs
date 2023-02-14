// See https://aka.ms/new-console-template for more information

//Введем исходный массив
int [] array = {1, 235, 531, 4, 6 , 15, 18, 235, 62};

//введем размерность массива
int n = 9;

//введем число, которое будем искать
int find = 235;

//Введем нулевой индекс массива 
int index = 0;

// Далее пошел цикл, в котором идет проверка если индекс меньше n
while (index < n)
{
 
 if (array [index] == find)
  {
    Console.WriteLine ("Index = "+index);
    break;
  }
 index++;



}