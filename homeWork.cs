using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int row, col;
			Console.WriteLine("Please enter row number and col number");
			row = Convert.ToInt32(Console.ReadLine());
			col = Convert.ToInt32(Console.ReadLine());
			string[][] matrix = new string[row][] ;
			int center = row / 2;
			for (int i = 0; i < row; i++)
			{
				matrix[i] = new string[col];
				for (int j = 0; j < col; j++)
				{
					if (i == j)
					{
						matrix[i][j] = "main";
					}
					else if (i + j == row - 1)
					{
						matrix[i][j] = "sub";
					}
					else if (i < j)
					{
						matrix[i][j] = "up";
					}
					else if (i > j)
					{
						matrix[i][j] = "down";
					}
				}
			}
			matrix[center][center] = "center";
			foreach (string[] matrixItem in matrix)
			{
				foreach (string arrItem in matrixItem)
				{
					Console.Write($"{arrItem}\t");
				}
				Console.WriteLine();
			}
		}
	}
}
