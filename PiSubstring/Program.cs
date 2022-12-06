using System;
using System.IO;

namespace PiSubstring
{
    class Program
    {
        public static int Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return f * Factorial(f - 1);
        }

        //factorial function        
        public static double Chudnovsky()
        {
            double S = 0;
            int iter = 1000;
            // greater iteration produce better approximation of Pi           
            int k;
            // iteration k
            double Pi = 0;
            // constant value
            const double k1 = 545140134, k2 = 13591409, k3 = -640320;
            const double k4 = 426880, k5 = 10005;
            Console.WriteLine("\nPi Approximation : \n\n");
            for (k = 0; k < iter; k++)
            {
                double numerator = Factorial(6 * k) * (k1 * k + k2);
                double denominator = Factorial(3 * k) * Math.Pow(Factorial(k), 3) * Math.Pow(k3, 3 * k);
                S += numerator / denominator;
                Pi = (k4 * Math.Sqrt(k5)) / S;
            }
            Console.WriteLine(Pi);
            return Pi;
        }
        static void Main(string[] args)
        {
            // Generation of Pi number
            double Pi = Chudnovsky();

            // Save number to file
            string fileName = "Pi.txt";
            File.WriteAllText(fileName, Convert.ToString(Pi));

            // Load number from file
            string readPi = System.IO.File.ReadAllText(@"Pi.txt");
        }
    }
}
