/*Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int [,] MatrixMulti (int [,] matrix1, int [,] matrix2)
{
	int [,] finalMatrix = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
	for (int i = 0; i < matrix1.GetLength(0); i++)
		for (int j = 0; j < matrix2.GetLength(1); j++)
			for (int w = 0; w < matrix2. GetLength(0); w++)
				finalMatrix[i,j] += matrix1[i,w]*matrix2[w,j];
	return finalMatrix;
}
Console.WriteLine("Input count of rows: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int cols1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of rows: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

if (cols1 != rows2)
	Console.WriteLine("Error");

int[,] arrayTask58_1 = Create2DArray(rows1,cols1);
Print2DArray(arrayTask58_1);
int[,] arrayTask58_2 = Create2DArray(rows2,cols2);
Print2DArray(arrayTask58_2);

int [,] resultMultiMatrix = MatrixMulti(arrayTask58_1, arrayTask58_2);
Print2DArray(resultMultiMatrix);
