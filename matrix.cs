using System;

public class Program
{
	private static void FillArrayRandom(int[, ] arr)
	{
		Random rand = new Random();
		for (int i = 0; i < arr.GetLength(0); ++i)
		{
			for (int j = 0; j < arr.GetLength(0); ++j)
			{
				arr[i, j] = rand.Next(0, 10);
			}
		}
	}

	private static void PrintArray(int[, ] arr)
	{
		for (int i = 0; i < arr.GetLength(0); ++i)
		{
			Console.WriteLine();
			for (int j = 0; j < arr.GetLength(0); ++j)
			{
				Console.Write("{0} ", arr[i, j]);
			}
		}

		Console.WriteLine();
	}

	private static int CalculateMEAN1(int[, ] arr)
	{
		int mean = 0, elem_count = 0;
		for (int i = 0; i < arr.GetLength(0); ++i)
		{
			for (int j = 0; j < arr.GetLength(0); ++j)
			{
				if (i >= j)
				{
					mean += arr[i, j];
					elem_count++;
				}
			}
		}

		mean /= elem_count;
		return mean;
	}

	private static int CalculateMEAN2(int[, ] arr)
	{
		int mean = 0, elem_count = 0;
		for (int i = 0; i < arr.GetLength(0); ++i)
		{
			for (int j = 0; j < arr.GetLength(0); ++j)
			{
				if (i <= j && (arr[i, j] % 2 == 1))
				{
					mean += arr[i, j];
					elem_count++;
				}
			}
		}

		mean /= elem_count;
		return mean;
	}

	private struct Position
	{
		public int m_x { get; private set; }

		public int m_y { get; private set; }

		public Position(int x, int y)
		{
			m_x = x;
			m_y = y;
		}
	}

	private static double GetDistance(Position p1, Position p2)
	{
		double distance;
		distance = Math.Sqrt(Math.Pow((p2.m_x - p1.m_x), 2) + Math.Pow((p2.m_y - p1.m_y), 2));
		return distance;
	}

	public static void Main()
	{
		Console.WriteLine("Insert matrix size: ");
		int arraySize = Int32.Parse(Console.ReadLine());
		int[, ] array = new int[arraySize, arraySize];
		
		FillArrayRandom(array);
		
		Console.WriteLine("\nGenerated matrx is: ");
		PrintArray(array);
		
		Console.WriteLine("\n**** 1th exercise ****");
		int mean1 = CalculateMEAN1(array);
		Console.WriteLine("\nThe MEAN is: {0}", mean1);
		
		Console.WriteLine("\n**** 2nd exercise ****");
		int mean2 = CalculateMEAN2(array);
		Console.WriteLine("\nThe MEAN is: {0}", mean2);
		
		Console.WriteLine("\n**** 3rd exercise ****");
		Random rand = new Random();
		int tmpX1, tmpY1;
		int tmpX2, tmpY2;
		
		tmpX1 = rand.Next(0, 10);
		tmpY1 = rand.Next(0, 10);
		tmpX2 = rand.Next(0, 10);
		tmpY2 = rand.Next(0, 10);
		
		Position pos1 = new Position(tmpX1, tmpY1);
		Position pos2 = new Position(tmpX2, tmpY2);
		
		Console.WriteLine("\nGenerated positions are: ");
		Console.WriteLine("Pos1({0}, {1}), Pos2({2}, {3}) ", pos1.m_x, pos1.m_y, pos2.m_x, pos2.m_y);
		double distance = GetDistance(pos1, pos2);
		Console.WriteLine("\nThe distance is: {0}", (float)distance);
	}
}
