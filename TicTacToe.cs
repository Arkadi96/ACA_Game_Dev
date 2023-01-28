using System;
namespace TickTacToe
{
	enum Field
	{
		Empty,
		O,
		X
	}
	
	class Program
	{
		private const int MAP_SIZE = 3;
		private const char EMPTY_SYMBOL = '-';
		private const char O_SYMBOL = 'O';
		private const char X_SYMBOL = 'X';
		private static Field[,] map = new Field[MAP_SIZE, MAP_SIZE];
		private static bool isFirstPlayer = true;
		private static bool isGameOver = false;
		private static int total_moves = 0;

		private static void buildMap()
		{
			for (int i = 0; i < MAP_SIZE; ++i)
			{
				for (int j = 0; j < MAP_SIZE; ++j)
				{
					map[i, j] = Field.Empty;
				}
			}
		}

		private static void displayMap()
		{
			Console.Clear();
			for (int i = 0; i < MAP_SIZE; ++i)
			{
				for (int j = 0; j < MAP_SIZE; ++j)
				{
					switch (map[i, j])
					{
						case Field.Empty:
							Console.Write($" {EMPTY_SYMBOL} ");
							break;
						case Field.O:
							Console.Write($" {O_SYMBOL} ");
							break;
						case Field.X:
							Console.Write($" {X_SYMBOL} ");
							break;
						default:
							Console.Write($" {EMPTY_SYMBOL} ");
							break;
					}
				}
				Console.WriteLine();
			}
		}

		private static void getInputTick()
		{
			Console.WriteLine("{1 ... 9} values are accepted");
			int n, i, j;
			bool b;
			do
			{
				Console.WriteLine((isFirstPlayer ? "First player place your X" : "Second player place your O"));
				string s = Console.ReadLine();
				b = int.TryParse(s, out n);
				i = (n - 1) / 3;
				j = (n + 2) % 3;
			} while (!b || n < 0 || n > MAP_SIZE * MAP_SIZE || map[i,j] != Field.Empty);

			total_moves++;
			map[i, j] = isFirstPlayer ? Field.X : Field.O;
		}

		private static bool checkForWinner()
		{
			Field f1 = map[0, 0];
			Field f2 = map[1, 0];
			Field f3 = map[2, 0];
			Field f4 = map[0, 1];
			Field f5 = map[0, 2];


			bool hasWinner = false;
			int[] check = new int[8];

			for (int i = 1; i < MAP_SIZE; ++i)
            		{
				if (map[0,i] == f1 && Field.Empty != f1)
                		{
					check[0] += 1;
                		}
				if (map[1, i] == f2 && Field.Empty != f2)
				{
					check[1] += 1;
				}
				if (map[2, i] == f3 && Field.Empty != f3)
				{
					check[2] += 1;
				}
				if (map[i, i] == f1 && Field.Empty != f1)
				{
					check[3] += 1;
				}
				if (map[MAP_SIZE - i - 1, i] == f3 && Field.Empty != f3)
				{
					check[4] += 1;
				}
				if (map[i, 0] == f1 && Field.Empty != f1)
				{
					check[5] += 1;
				}
				if (map[i, 1] == f4 && Field.Empty != f4)
				{
					check[6] += 1;
				}
				if (map[i, 2] == f5 && Field.Empty != f5)
				{
					check[7] += 1;
				}
			}

			for (int i = 0; i < check.Length; ++i)
            		{
				if (check[i] == 2)
               			{
					hasWinner = true;
					break;
                		}
            		}
			
			return hasWinner;
		}

		private static void checkForEndGame()
        	{
			if (checkForWinner())
            		{
				isGameOver = true;
				Console.WriteLine("Winner is " + (isFirstPlayer ? "First player X" : "First player O"));
			} else if (total_moves >= 9)
            		{
				isGameOver = true;
				Console.WriteLine("Its a soldi draw!");
			} else
            		{
				isGameOver = false;
			}

			isFirstPlayer = !isFirstPlayer;
		}

		public static void Main()
		{
			buildMap();
			while (!isGameOver)
            		{
                		displayMap();
				getInputTick();
				checkForWinner();
				checkForEndGame();
            		}
        	}
    }
}
