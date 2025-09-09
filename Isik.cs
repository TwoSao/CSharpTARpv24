using System;

namespace CSharpTARpv24
{
    internal class Isik
    {
        public string eesnimi;
        public string perenimi;
        public int suuniaasta = 2009;

        public Isik()
        {
            
        }

        public Isik(string eesnimi, string perenimi, int suuniaasta)
        {
            this.eesnimi = eesnimi;
            this.perenimi = perenimi;
            this.suuniaasta = suuniaasta;
        }

        public void Prindi_andmed()
        {
            Console.WriteLine($"Isiku andmed: {eesnimi}, {perenimi}, Sündinud: {suuniaasta}");
        }
    }
}