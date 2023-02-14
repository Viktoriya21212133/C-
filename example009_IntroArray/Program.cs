// Напишите программу, которая найдет максимум из 9ти чисел


int Max (int arg1, int arg2, int arg3)

{
    int res = arg1;
    if (arg2> res) res = arg2;
    if (arg3> res) res = arg3;
    return res;
}

//              0  1  2  3  4  5  6  7  8
int [] array = {1, 2, 3, 4, 5856, 6, 7, 8, 9};

// array [0] = 12;
// Console.WriteLine (array [4]);

//Введем новую переменную макс, в которую положим значение первого аргумента
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max (max1, max2, max3);

int max = Max (
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));

Console.WriteLine ("Max = " +max);