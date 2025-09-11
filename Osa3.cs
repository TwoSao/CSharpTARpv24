using System;

namespace CSharpTARpv24
{
    public class Osa3
    {
        internal class NumberProcessing
        {
            public static int[] GenerateSquares(int min, int max)
            {
                Random  random = new Random();
                int m = random.Next(min, max);
                int n = random.Next(min, max);
                Console.WriteLine(m);
                Console.WriteLine(n);
                Console.WriteLine(Math.Abs(m-n)+1);
                int[] massive = new int[Math.Abs(m-n)+1];
                int k = 0;
                
                if (m < n)
                {
                    for (int i =m; i <= n; i++)
                    {
                        
                        massive[k] = i*i;
                        k++;
                    }
                }
                else
                {
                    for (int i = n; i <= m; i++)
                    {
                        massive[k] = i*i;
                        k++;
                    }
                }
                return massive;
        
                
            }
        
            
        }

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

        public static string KuniMarksonani(string märksõna, string frass)
        {
            do
            {
                Console.WriteLine("Osta elevant ära!");
                frass = Console.ReadLine();
            } while (frass.ToLower() != märksõna.ToLower());
            return frass;
        }

        public static void GuessNmber()
        {
            Random random = new Random();
            
            while (true)
            {
                
                int n = random.Next(1, 3);
                            int k = 5;
                            while (k>=0)
                            {
                                Console.WriteLine("Sisesta number");
                                int number = int.Parse(Console.ReadLine());
                                if (number == n)
                                {
                                    Console.WriteLine("See on õige number");
                                    break;
                                }
                                else if (number < n)
                                {
                                    Console.WriteLine("Sina number väikem");
                                    k--;
                                }
                                else
                                {
                                    Console.WriteLine("Sina number suurem");
                                    k--;
                                }
                
                                
                                
                            }

                            Console.WriteLine("Kas veel kord?");
                            string kord = Console.ReadLine();
                            if (kord.ToLower() == "y")
                            {
                                continue;
                            }
                            else if (kord.ToLower() == "n")
                            {
                                break;
                            }
                            
            }

            Console.WriteLine("Mängu lõpu");
            
            
            
        }

        public static Tuple<int, int, int, int> LargestFour
        {
            
        }
    }
    
}