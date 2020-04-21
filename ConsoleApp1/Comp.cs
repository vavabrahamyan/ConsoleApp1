using System;

namespace IdleGame
{
    class Comp
    {
        public readonly int[] CompNumber = new int[4];
        private Random rand = new Random();
        public Comp()
        {
            CompNumber[0] = rand.Next(1, 10);
            CompNumber[1] = Initialization_Besides(CompNumber[0]);
            CompNumber[2] = Initialization_Besides(CompNumber[0], CompNumber[1]);
            CompNumber[3] = Initialization_Besides(CompNumber[0], CompNumber[1], CompNumber[2]);
        }
        private int Initialization_Besides(int num)
        {
            int a = rand.Next(1, 10);
            while(a == num)
            {
                a = rand.Next(1, 10);
            }
            return a;
        }
        private int Initialization_Besides(int num1, int num2)
        {
            int a = rand.Next(1, 10);
            while (a == num1 || a == num2)
            {
                a = rand.Next(1, 10);
            }
            return a;
        }
        private int Initialization_Besides(int num1, int num2, int num3)
        {
            int a = rand.Next(1, 10);
            while (a == num1 || a == num2 || a == num3)
            {
                a = rand.Next(1, 10);
            }
            return a;
        }
    }
}
