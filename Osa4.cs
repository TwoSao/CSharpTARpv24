namespace Kordamine;

internal class Osa4
{
    public static void Kirjuta_failisse()
    {
        try
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                "kuud.txt");
            StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
            Console.WriteLine("Sisesta mingi tekst: ");
            string lause = Console.ReadLine();
            text.WriteLine(lause);
            text.Close();
        }
        catch (Exception)
        {
            Console.WriteLine("Mingi viga failiga");
        }
    }

    public static void Failide_lugemine(string failinimi)
    {
        try
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                "kuud.txt");
            StreamReader text = new StreamReader(path);
            string laused = text.ReadToEnd();
            text.Close();
            Console.WriteLine(laused);
        }
        catch (Exception)
        {
            Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
        }
    }

    public static List<string> Ridade_lugemine()
    {
        List<string> kuude_list = new List<string>();
        try
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                "kuud.txt");
            foreach (string rida in File.ReadAllLines(path))
            {
                kuude_list.Add(rida);
            }

            Console.WriteLine("Kõik kuud failist:");
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
            kuude_list.Remove("Juuni");
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Pärast muudatusi-----------");
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Viga failiga!");
        }
        return kuude_list;
    }
    
}