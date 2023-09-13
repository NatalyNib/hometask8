/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int [,] Create2DArray (int row, int column)
{
int [,] createdArray = new int[row,column];
for (int i = 0; i < row; i++)
		for (int j = 0; j < column; j++)
		createdArray[i,j] = new Random().Next(0,10);
return createdArray;
}
void Print2DArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
			{
			Console.Write(array[i,j] + " ");
			}
			Console.WriteLine();
    }
Console.WriteLine(" ");
} 

void MinSumRow (int [,] array)
{
	int [] sumRowArray = new int [array.GetLength(0)];
	int sum;
	for (int i = 0; i < array.GetLength(0); i++)
		{
			sum = 0;
			for (int j = 0; j < array.GetLength(1); j++)
				{
				sum += array[i,j];
				}
			sumRowArray [i] = sum;
		}
	int minSumArr = sumRowArray [0];
	int numRow = 1;
	for (int v = 0; v < sumRowArray.Length; v++)
	{
		if (sumRowArray[v] < minSumArr)
		{
			minSumArr = sumRowArray[v];
			numRow = v + 1;
		}
	}
	Console.Write($"Минимальной является строка {numRow }, сумма строки равна { minSumArr }");
}

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] arrayTask56 = Create2DArray(rows,cols);
Print2DArray(arrayTask56);
MinSumRow (arrayTask56);
