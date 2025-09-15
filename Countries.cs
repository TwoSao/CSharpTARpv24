namespace CSharpTARpv24;


public class Ct
{
    public void Run()
    {
        var counties = new Dictionary<string, string>()
        {
            { "Harjumaa", "Tallinn" },
            { "Tartumaa", "Tartu" },
            { "Pärnumaa", "Pärnu" },
            { "Ida-Virumaa", "Jõhvi" },
            { "Lääne-Virumaa", "Rakvere" }
        };

        var random = new Random();

        while (true)
        {
            Console.WriteLine("\n--- Menüü ---");
            Console.WriteLine("1. Leia pealinn maakonna järgi");
            Console.WriteLine("2. Leia maakond pealinna järgi");
            Console.WriteLine("3. Lisa andmed");
            Console.WriteLine("4. Mängurežiim");
            Console.WriteLine("0. Väljumine");
            Console.Write("Vali tegevus: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Sisesta maakond: ");
                    string county = Console.ReadLine();
                    Console.WriteLine(counties.ContainsKey(county)
                        ? $"Maakonna {county} pealinn on {counties[county]}"
                        : "Andmed puuduvad.");
                    break;

                case "2":
                    Console.Write("Sisesta pealinn: ");
                    string capital = Console.ReadLine();
                    string foundCounty = null;
                    foreach (var kvp in counties)
                        if (kvp.Value.Equals(capital, StringComparison.OrdinalIgnoreCase))
                            foundCounty = kvp.Key;
                    Console.WriteLine(foundCounty != null
                        ? $"Pealinn {capital} asub maakonnas {foundCounty}"
                        : "Andmed puuduvad.");
                    break;

                case "3":
                    Console.Write("Sisesta maakond: ");
                    county = Console.ReadLine();
                    Console.Write("Sisesta pealinn: ");
                    capital = Console.ReadLine();
                    counties[county] = capital;
                    Console.WriteLine("✅ Kirje lisatud!");
                    break;

                case "4":
                    Console.Write("Mitu küsimust mängida (vaikimisi 5): ");
                    string input = Console.ReadLine();
                    int rounds = 5;
                    if (int.TryParse(input, out int r)) rounds = r;

                    int correct = 0;
                    var keys = new List<string>(counties.Keys);
                    var values = new List<string>(counties.Values);

                    for (int i = 0; i < rounds; i++)
                    {
                        bool askCounty = random.Next(2) == 0;

                        if (askCounty)
                        {
                            county = keys[random.Next(keys.Count)];
                            Console.Write($"Maakonna {county} pealinn: ");
                            string ans = Console.ReadLine();
                            if (ans.Equals(counties[county], StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("✅ Õige!");
                                correct++;
                            }
                            else
                                Console.WriteLine($"❌ Vale. Vastus: {counties[county]}");
                        }
                        else
                        {
                            capital = values[random.Next(values.Count)];
                            Console.Write($"Pealinna {capital} maakond: ");
                            string ans = Console.ReadLine();
                            foundCounty = null;
                            foreach (var kvp in counties)
                                if (kvp.Value.Equals(capital, StringComparison.OrdinalIgnoreCase))
                                    foundCounty = kvp.Key;
                            if (ans.Equals(foundCounty, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("✅ Õige!");
                                correct++;
                            }
                            else
                                Console.WriteLine($"❌ Vale. Vastus: {foundCounty}");
                        }
                    }

                    Console.WriteLine($"Tulemus: {correct}/{rounds} ({(double)correct / rounds * 100:F2}%)");
                    break;

                case "0":
                    Console.WriteLine("Väljumine...");
                    return;

                default:
                    Console.WriteLine("Vale valik!");
                    break;
            }
        }
    }
}