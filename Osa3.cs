using System;

namespace CSharpTARpv24
{
    public class Osa3
    {
        // internal class NumberProcessing
        // {
        //     public static int[] GenerateSquares(int min, int max)
        //     {
        //         Random  random = new Random();
        //         int m = random.Next(min, max);
        //         int n = random.Next(min, max);
        //         Console.WriteLine(m);
        //         Console.WriteLine(n);
        //         Console.WriteLine(Math.Abs(m-n)+1);
        //         int[] massive = new int[Math.Abs(m-n)+1];
        //         int k = 0;
        //         
        //         if (m < n)
        //         {
        //             for (int i =m; i <= n; i++)
        //             {
        //                 
        //                 massive[k] = i*i;
        //                 k++;
        //             }
        //         }
        //         else
        //         {
        //             for (int i = n; i <= m; i++)
        //             {
        //                 massive[k] = i*i;
        //                 k++;
        //             }
        //         }
        //         return massive;
        //
        //         
        //     }
        //
        //     
        // }

        public static double[] Tekstist_arvud()
                    {
                        Console.WriteLine("Sisesta arvud koma või tühikuga eraldatult: ");
                        string sisend = Console.ReadLine();
                        char[] eraldajad = new char[] { ' ' };//
                        
                        string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);
                        double[] arvud = new double[osad.Length];
                        for (int i = 0; i < osad.Length; i++)
                        {
                            arvud[i] = Convert.ToDouble(osad[i]);
                        }
                        return arvud;
                    }
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double summa = arvud.Sum();
            double keskmine = arvud.Average();
            double korrutis = 1;
            foreach (double arv in arvud)
            {
                korrutis *= arv;
            }
            return Tuple.Create(keskmine, korrutis, summa);
        }
    }
    
}