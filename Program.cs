// See https://aka.ms/new-console-template for more information



//Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
Console.WriteLine("Задан массив");
int rows = 3;
int colums = 4;
int[,] array = new int [rows, colums];
Fillarray(array, rows, colums);
Printarray(array, rows, colums);
Console.WriteLine();
Console.WriteLine("Массив с убыванием элементов каждой строки");
SecondArray(array, rows, colums);
Printarray(array, rows, colums);


}

void SecondArray(int[,] array, int rows, int colums)
{

for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int n = 0; n < colums - 1; n++)
            
            if (array [i,n] < array [i,n+1])
            {
                int temp = array[i,n+1];
                array[i,n+1] = array[i,n];
                array[i,n] = temp;
            }         
            
        }

    }
}

void Fillarray(int[,] array, int rows, int colums)
{
    Random random = new Random();
    rows = array.GetLength(0);
    colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = random.Next(0, 10);
                       
        }
    }
}

void Printarray(int[,] array, int rows, int colums)
{
    Random random = new Random();
    rows = array.GetLength(0);
    colums = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Zadacha54();


//Задача 56: Задайте прямоугольный двумерный массив. Напишите
//программу, которая будет находить строку с наименьшей суммой элементов


void Zadacha56()
{
int rows = 4;
int colums = 4;
int[,] array = new int [rows, colums];
Fillarray(array, rows, colums);
Printarray(array, rows, colums);
Console.WriteLine();
MinSumElement(array, rows, colums);
}

void MinSumElement(int[,] array, int rows, int colums)
{

int minindex = 0;
int minsum = int.MaxValue;

for (int i = 0; i < rows; i++)
    {
        int sum = 0;

        for (int j = 0; j < colums; j++)
        {           
            sum = array[i,j] + sum;
        }

        if (sum < minsum)
        {
            minsum = sum;
            minindex = i+1;
        }     

    }

Console.WriteLine("Строка с наименьшей суммой элементов: " + (minindex) + "; сумма элементов данной строки равна: " + (minsum));
}
Zadacha56();

