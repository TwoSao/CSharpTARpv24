using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kordamine;

namespace CSharpTARpv24
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            // Osa3. Ul1
            // int[] massive = Osa3.NumberProcessing.GenerateSquares(-10, 10);
            // foreach (int m in massive)
            // {
            //     Console.WriteLine(m);
            // }

            // Osa3. Ul2
            //
            // double[] arvud = Osa3.Tekstist_arvud();
            // var tulemus = Osa3.AnalüüsiArve(arvud);
            // Console.WriteLine($"Summa: {tulemus.Item1:F2}, keskmine {tulemus.Item2:F2}, Korrutis: {tulemus.Item3:F2}");

            // Osa3. U3


            // Osa3. U4
            // Console.WriteLine("Sisesta märksõna");
            // string marksõna = Console.ReadLine();
            // string frass = Console.ReadLine();
            // Osa3.KuniMarksonani(marksõna, frass);

            // Osa3. Ul5
            // Osa3.GuessNmber();

            // Osa3. Ul6
            // double[] arvud = new double[4];
            // for (int i = 0; i < 4; i++)
            // {
            //     Console.WriteLine($"Sisesta {i + 1}. arv (0–9): ");
            //     arvud[i] = Convert.ToDouble(Console.ReadLine());
            // }
            //
            // int tulemus = Osa3.SuurimNeljarv(arvud);
            // if (tulemus != -1)
            // {
            //     Console.WriteLine("Suurim võimalik arv: " + tulemus);
            // }

            // Osa3. Ul7
            // Osa3.GenereeriKorrutustabel();

            // Osa4. Teooria
            // Console.WriteLine("Sise failinimi");
            // string failinimi = Console.ReadLine();
            // Osa4.Failide_lugemine(failinimi);
            // Osa4.Kirjuta_failisse();
            // Osa4.Ridade_lugemine();

            //Osa5. Ul1.

            // Osa5. Ul2
            // Console.OutputEncoding = Encoding.UTF8;
            // Ct run = new Ct();
            // run.Run();

            // List<Toode> toidud = new List<Toode>
            // {
            //     new Toode { Nimi = "Õun", Kalorid100g = 52 },
            //     new Toode { Nimi = "Leib", Kalorid100g = 265 },
            //     new Toode { Nimi = "Piim", Kalorid100g = 42 }
            // };
            //
            // Inimene user = new Inimene();
            // Console.Write("Nimi: ");
            // user.Nimi = Console.ReadLine();
            // Console.Write("Vanus: ");
            // user.Vanus = int.Parse(Console.ReadLine());
            // Console.Write("Sugu (Mees/Naine): ");
            // user.Sugu = Console.ReadLine();
            // Console.Write("Pikkus (cm): ");
            // user.Pikkus = double.Parse(Console.ReadLine());
            // Console.Write("Kaal (kg): ");
            // user.Kaal = double.Parse(Console.ReadLine());
            // Console.Write("Aktiivsustase (1.2-2.0): "); user.Aktiivsustase = double.Parse(Console.ReadLine());
            //
            // double kaloridPaevas = user.ArvutaKalorid();
            // Console.WriteLine($"\nPäevane kalorivajadus: {kaloridPaevas:F2} kcal\n");
            //
            // Console.WriteLine("Soovitatav kogus toidust (g):");
            // foreach (var t in toidud)
            // {
            //     double gramm = t.KogusGrammides(kaloridPaevas);
            //     Console.WriteLine($"{t.Nimi}: {gramm:F1} g");
            // }


            // Osa3. Teooria Massiivid, List, Kordused
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

            // Osa1
            // int choose  = Convert.ToInt32(Console.ReadLine());
            // Osa1.Main(choose);

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


            // Isev
            List<Student> students = new List<Student>()
            {
                new Student("Alice", new List<int> { 5, 3, 2 }),
                new Student("Bob", new List<int> { 5, 2, 2 }),
                new Student("Charlie", new List<int> { 5, 5, 5 })
            };
            var sortedStudents = students.OrderByDescending(s => s.GetAverage()).ToList();
            foreach (var s in sortedStudents)
            {
                Console.WriteLine($"{s.Name} : {s.GetAverage():F2}");
            }
            
            
            List<Film> films = new List<Film>()
            {
                new Film("Inception", 2010, "Sci-Fi"),
                new Film("The Godfather", 1972, "Crime"),
                new Film("The Shawshank Redemption", 1994, "Drama"),
                new Film("The Dark Knight", 2008, "Action"),
                new Film("Pulp Fiction", 1994, "Crime")
            };
            
            Filmid filmCollection = new Filmid(films);
            
            var groupedFilms = filmCollection.GroupByGenre();
            foreach (var genre in groupedFilms)
            {
                Console.WriteLine($"{genre.Key}:");
                foreach (var film in genre.Value)
                {
                    Console.WriteLine($"  {film.Name} ({film.Aasta})");
                }
            }
            
            
        }
    }
}
