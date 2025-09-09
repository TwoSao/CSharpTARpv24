using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTARpv24
{
    internal class Osa1
    {
        public static void Main(int choose)
        {
            
            switch (choose)
            {
                case 1: 
                    Console.WriteLine("Mis sinu nimi on?");
                    string nimi = Console.ReadLine();
                    if (nimi.ToLower() == "juku")
                    {
                        Console.WriteLine("Kui vana sa oled?");
                        try
                        {
                            int aasta = int.Parse(Console.ReadLine());
                            Console.WriteLine(Osa1.Pilet(aasta));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                
                        }

                    }
                    
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Isiku number 1 sisestage oma nimi");
                        string nimi1 = Console.ReadLine();
                        Console.WriteLine("Isiku number 2 sisestage oma nimi");
                        string nimi2 = Console.ReadLine();
                        Console.WriteLine(Osa1.Inimesed(nimi1, nimi2));

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                    break;
                case 3:
                    Console.WriteLine("Kas soovite teha renoveerimistöid?\n");
                    string remonti = Console.ReadLine();
                    if (remonti.ToLower() != "jah")
                    {
                        Console.WriteLine("Ei taha, siis ei taha");
                    }
                    else
                    {
                        try
                        {
                            Console.WriteLine("Sisestage seinte pikkus");
                            int esimene_pikkus = int.Parse(Console.ReadLine());
                            int teine_pikkus = int.Parse(Console.ReadLine());
                            Console.WriteLine("Kirjutage põrandakatte ruutmeetri hind");
                            int hind = int.Parse(Console.ReadLine());
                            Console.WriteLine(Osa1.Pikkus(esimene_pikkus, teine_pikkus, hind));
                    

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }
                    }
                    break;
                case 4:
                    Console.WriteLine("Kirjuta hind koos allahindlusega");
                    double hinds = double.Parse(Console.ReadLine());
                    Console.WriteLine(Osa1.Hind(hinds));
                    break;
                // case 5:
                //     Console.WriteLine("Mis temperatuur teie toas on?");
                //     Console.ReadLine();

                    
                    
            }
        }
        public static float Kalkulator(float x, float y)
        {   
            
            float vastus = x/y;

            return vastus;
        }
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1:
                    kuu = "Jaanuar";
                    break;
                case 2:
                    kuu = "Februar";
                    break;
                case 3:
                    kuu = "Maru";
                    break;
                case 4:
                    kuu = "April";
                    break;
                case 5:
                    kuu = "May";
                    break;
                case 6:
                    kuu = "June";
                    break;
                case 7:
                    kuu = "July";
                    break;
                case 8:
                    kuu = "August";
                    break;
                case 9:
                    kuu = "September";
                    break;
                case 10:
                    kuu = "October";
                    break;
                case 11:
                    kuu = "November";
                    break;
                case 12:
                    kuu = "December";
                    break;
                default:
                    kuu = "Viga";
                    break;
            }
            return kuu;
        }

        public static string Hooaeg(int kuu_nr)
        {
            string aastaaeg = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12)
            {
                aastaaeg = "Talv/Зима";
            }
            else if (kuu_nr >2 && kuu_nr < 6)
            {
                aastaaeg = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                aastaaeg = "Suvi";
            }
            else if (kuu_nr > 9 && kuu_nr < 12)
            {
                aastaaeg = "Sügis";
            }
            else
            {
                aastaaeg = "Viga";
            }
            return aastaaeg;
        }

        public static string Pilet(int aasta)
        {
            string pileti = "-";
            if (aasta > 0 && aasta < 6)
            {
                pileti = "Tasuta";
            }
            else if (aasta > 5 && aasta < 14)
            {
                    pileti = "lastepilet";
            }
            else if (aasta > 13 && aasta < 66)
            {
                pileti = "täispilet";
            }
            else if (aasta > 65 && aasta < 100)
            {
                pileti = "sooduspilet";
            }
            else if (aasta > 100 && aasta < 0)
            {
                pileti = "viga andmetega";
            }

            return pileti;
        }

        public static string Inimesed(string name1, string name2)
        {
            string pingi = "";
            if (name1.ToLower() == "martin" && name2.ToLower() == "illia")
            {
                pingi = "naabrid";
                
            }
            else if (name1.ToLower() == "mark" && name2.ToLower() == "marek")
            {
                pingi = "naabrid";
            }
            else
            {   
                pingi = "ei naabri";
            }
            return pingi;
            
        }

        public static string Pikkus(int a, int b, int c)
        {
            int ruut = a * b;
            int hind = ruut / c;
            string pikkus = $"Põrandapind: {ruut}, Põranda vahetuse hind ruutmeetri kohta: {hind}$";
            
            
            return pikkus;
        }

        public static double Hind(double a)
        {
            a = a / 0.70;
            return a;

        }
    }
}