using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    public class Szemely
    {
        protected string nev;
        private int kor;

        public Szemely(string nev, int kor)
        {
            this.nev = nev;
            Kor = kor;
        }

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set
            {
                if (value >= 0)
                    kor = value;
                else
                    throw new ArgumentException("Az életkor nem lehet negatív.");
            }
        }
    }

    public class BankSzamla
    {
        private int egyenleg;

        public int Egyenleg
        {
            get { return egyenleg; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Az egyenleg nem lehet negatív.");
                egyenleg = value;
            }
        }

        public BankSzamla(int kezdoEgyenleg = 0)
        {
            Egyenleg = kezdoEgyenleg;
        }

        public void Betesz(int osszeg)
        {
            if (osszeg < 0)
                throw new ArgumentException("Negatív összeget nem lehet betenni.");
            Egyenleg += osszeg;
        }

        public void Kivesz(int osszeg)
        {
            if (osszeg < 0)
                throw new ArgumentException("Negatív összeget nem lehet kivenni.");
            if (Egyenleg - osszeg < 0)
                throw new ArgumentException("Nincs elég egyenleg.");
            Egyenleg -= osszeg;
        }
    }

    public class Hallgato : Szemely
    {
        private string neptunKod;

        public Hallgato(string nev, int kor, string neptunKod)
            : base(nev, kor)
        {
            NeptunKod = neptunKod;
        }

        public string NeptunKod
        {
            get { return neptunKod; }
            set
            {
                if (value.Length > 6)
                    throw new ArgumentException("A Neptun kód nem lehet hosszabb 6 karakternél.");
                neptunKod = value;
            }
        }
    }






    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely("Ibolya", 22);
            Console.WriteLine($"A személy neve: {person.Nev} és életkora: {person.Kor}");
        }
    }

}