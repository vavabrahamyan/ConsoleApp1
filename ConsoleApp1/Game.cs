using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace IdleGame
{
    static class Game
    {
        static Comp Comp = new Comp();

        static int[] UsersNumber = new int[4];



        static internal void ReadUsersNumber()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        UsersNumber[i] = 1;
                        break;
                    case ConsoleKey.D2:
                        UsersNumber[i] = 2;
                        break;
                    case ConsoleKey.D3:
                        UsersNumber[i] = 3;
                        break;
                    case ConsoleKey.D4:
                        UsersNumber[i] = 4;
                        break;
                    case ConsoleKey.D5:
                        UsersNumber[i] = 5;
                        break;
                    case ConsoleKey.D6:
                        UsersNumber[i] = 6;
                        break;
                    case ConsoleKey.D7:
                        UsersNumber[i] = 7;
                        break;
                    case ConsoleKey.D8:
                        UsersNumber[i] = 8;
                        break;
                    case ConsoleKey.D9:
                        UsersNumber[i] = 9;
                        break;
                    case ConsoleKey.D0:
                        UsersNumber[i] = 0;
                        break;

                }
            }

        }
        public static bool[] AreTastes(int[] array1, int[] array2)
        {
            bool[] arr = new bool[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j] && i == j)
                    {
                        arr[i] = true;
                    }
                }
            }
            return arr;
        }
        public static int CountOfTastes(int[] array1, int[] array2)
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static void GameDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorVisible = false;
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.Write("For Start Game Press Any Key");
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.Write("Game is started");
            Thread.Sleep(800);

            for (int i = 0; i < 9; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Step {i+1}/9");
                Console.WriteLine("Guess the four-digit number");
                ReadUsersNumber();
                if ((Comp.CompNumber[0] == UsersNumber[0]) && (Comp.CompNumber[1] == UsersNumber[1]) &&
                     (Comp.CompNumber[2] == UsersNumber[2]) && (Comp.CompNumber[3] == UsersNumber[3]))
                {
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.CursorVisible = false;
                    if (i < 6)
                    {
                        Console.Write("Wow it's cosmos, You Win");
                    }
                    else
                    {
                        Console.WriteLine("Lave karoxacar");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($" Tastes  {CountOfTastes(UsersNumber, Comp.CompNumber)}  numbers");
                    Console.Write($"Tastes in positions == > ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($"{AreTastes(UsersNumber, Comp.CompNumber)[j]}    ");
                    }
                    if (i > 5 && i < 8)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lav ches xaxum");
                    }
                    if (i == 8)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        Console.Write("Xaxal chgites");
                        Console.Write("Game Over");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
        }
    }
}
    