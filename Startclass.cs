using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTARpv24
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            // int[] massive = Osa3.NumberProcessing.GenerateSquares(-10, 10);
            // foreach (int m in massive)
            // {
            //     Console.WriteLine(m);
            // }
            // Ülessane 2

            double[] arvud = Osa3.Tekstist_arvud();
            var tulemus = Osa3.AnalüüsiArve(arvud);
            Console.WriteLine($"Summa: {tulemus.Item1:F2}, keskmine {tulemus.Item2:F2}, Korrutis: {tulemus.Item3:F2}");


            // 3. Osa Massiivid, List, Kordused

            //List<string> names = new List<string>();

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine($"Nimi {i+1}:");
            //     names.Add(Console.ReadLine());
            // }

            // foreach (string name in names)
            // {
            //     Console.WriteLine(name);
            // }
            // int [] arvud = new int[10];
            // Random rnd = new Random();
            // int j = 0;
            // while (j<10)
            // {
            //     
            //     Console.WriteLine(j + 1);
            //     arvud[j] = rnd.Next(0, 1010);
            //     j++;    
            // }
            //
            // foreach (int arv in arvud)
            // {
            //     Console.WriteLine(arv);
            // }
            //
            // int j = 0;
            // List<Isik> isikud = new List<Isik>();
            // do
            // {
            //     Console.WriteLine(j + 1);
            //     Isik isik = new Isik();
            //     Console.WriteLine("Enter the eesnimi: ");
            //     isik.eesnimi = Console.ReadLine();
            //     names.Add(isik.eesnimi);
            //     Console.WriteLine("Enter the perenimi: ");
            //     isik.perenimi = Console.ReadLine();
            //     names.Add(isik.perenimi);
            //     Console.WriteLine("Enter the suuniaasta: ");
            //     isik.suuniaasta = int.Parse(Console.ReadLine());
            //     isikud.Add(isik);
            //     
            //     j++;
            // } while (j<5);
            // isikud.Sort((x,y) => x.eesnimi.CompareTo(y.eesnimi));
            // Console.WriteLine($"Kokku on, {isikud.Count()}, isikud");
            // foreach (Isik isik in isikud)
            // {
            //     isik.Prindi_andmed();
            // }
            //
            // Console.OutputEncoding = Encoding.UTF8;
            // Console.WriteLine("Tere! Valige toiming\n1.Pilet\n2.Pinginamer\n3.Ruut\n4.Hind\n");
            //
            // int choose  = Convert.ToInt32(Console.ReadLine());
            // Osa1.Main(choose);
            //
            // Osa 2
            //



            // int kuu_number2;
            // Random rnd = new Random();
            // kuu_number = rnd.Next(1, 12);
            // kuu_number2 = rnd.Next(1, 12);
            // string nimetus=Osa1.Kuu_nimetus(kuu_number);
            // string nimetus_aasta=Osa1.Hooaeg(kuu_number2);
            // Console.WriteLine($"{kuu_number}: {nimetus}");
            // Console.WriteLine($": {nimetus_aasta}");


            // Console.OutputEncoding = Encoding.UTF8;
            // Console.BackgroundColor = ConsoleColor.Red;
            // Console.WriteLine("Palus sisesta esimene arv:");
            // int a = int.Parse(Console.ReadLine());
            // Console.WriteLine("Palun sisesta teine arv:");
            // int b = int.Parse(Console.ReadLine());
            // Console.WriteLine($"Vastus Esimene arv {a} + Teine arv {b} = {a + b}");
            //
            // double c = double.Parse(Console.ReadLine());
            // Console.WriteLine(c);
            //
            // float d = float.Parse(Console.ReadLine());
            // Console.WriteLine(d);
            //
            // Random random = new Random();
            // a = random.Next(a);
            // Console.WriteLine(a);
            // float v = Osa1.Kalkulator(a, b);
            // Console.WriteLine(v);
            // Osa1
        }
    }
}
