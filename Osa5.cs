namespace CSharpTARpv24;

    class Toode
    {
        public string Nimi { get; set; }
        public double Kalorid100g { get; set; }

        public double KogusGrammides(double kaloridPaevas)
        {
            return kaloridPaevas / Kalorid100g * 100;
        }
    }

    class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; } 
        public double Pikkus { get; set; }
        public double Kaal { get; set; }
        public double Aktiivsustase { get; set; }

        public double ArvutaKalorid()
        {
            double bmr;
            if (Sugu.ToLower() == "mees")
                bmr = 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
            else
                bmr = 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);

            return bmr * Aktiivsustase;
        }
    }
    