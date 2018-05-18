//Task: find the last 2 decimal digits of n! (n>=0 && n<=1 000 000 000)
//

using System;
public class Factorial
    {
        public static void Main()
        {
            int D = int.Parse(Console.ReadLine());
            int units;
            int tens;
            int[] first9 = { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            int[] input = new int[D];

            for (int i = 0; i < D; i++)
                input[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < D; i++)
            {
                if (input[i] >= 10)
                {
                    units = 0;
                    tens = 0;
                }
                else if (input[i] > 5)
                {
                    units = 0;
                    tens = (input[i] * ((first9[input[i] - 1] / 10) % 10)) % 10;
                }
                else
                {
                    units = first9[input[i]] % 10;
                    tens = (first9[input[i]] / 10) % 10;
                }
                Console.WriteLine("{0} {1}", tens, units);
            }
        }
    }