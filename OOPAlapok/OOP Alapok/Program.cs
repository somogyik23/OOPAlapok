using System;
using System.Collections.Generic;

namespace OOPAlapok
{
    
    class Szemely
    {
        protected string nev;
        private int kor;

        public Szemely(string nev, int kor)
        {
            this.nev = nev;
            Kor = kor;
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value < 0 ? 0 : value; }
        }

        public override string ToString()
        {
            return $"Név: {nev}, Kor: {kor}";
        }

        
        public virtual void Bemutatkozik()
        {
            Console.WriteLine(ToString());
        }
    }

    
    class BankSzamla
    {
        private int egyenleg;

        public BankSzamla(int kezdoEgyenleg = 0)
        {
            egyenleg = Math.Max(0, kezdoEgyenleg);
        }

        public void Betesz(int osszeg)
        {
            if (osszeg > 0) egyenleg += osszeg;
        }

        public void Kivesz(int osszeg)
        {
            if (osszeg > 0 && egyenleg - osszeg >= 0)
                egyenleg -= osszeg;
            else
                Console.WriteLine("Nincs elegendő egyenleg!");
        }

        public override string ToString()
        {
            return $"Egyenleg: {egyenleg} Ft";
        }
    }

    
    class Hallgato : Szemely
    {
        private string neptunKod;

        public Hallgato(string nev, int kor, string neptunKod) : base(nev, kor)
        {
            NeptunKod = neptunKod;
        }

        public string NeptunKod
        {
            get { return neptunKod; }
            set
            {
                if (value.Length <= 6)
                    neptunKod = value;
                else
                    neptunKod = value.Substring(0, 6);
            }
        }

        public override string ToString()
        {
            return $"Hallgató - Név: {nev}, Kor: {Kor}, Neptun: {NeptunKod}";
        }

        public override void Bemutatkozik()
        {
            Console.WriteLine($"Hallgató vagyok, a nevem {nev}, Neptun kódom: {NeptunKod}");
        }
    }

    
    class Dolgozo : Szemely
    {
        private int ber;

        public Dolgozo(string nev, int kor, int ber) : base(nev, kor)
        {
            this.ber = ber;
        }

        public override string ToString()
        {
            return $"Dolgozó - Név: {nev}, Kor: {Kor}, Bér: {ber} Ft";
        }

        public override void Bemutatkozik()
        {
            Console.WriteLine($"Dolgozó vagyok, a nevem {nev}, havi bérem {ber} Ft");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Szemely sz1 = new Szemely("Kiss Péter", 25);
            Console.WriteLine(sz1);

            
            BankSzamla szamla = new BankSzamla(1000);
            szamla.Betesz(500);
            szamla.Kivesz(2000);
            Console.WriteLine(szamla);

            
            List<Hallgato> hallgatok = new List<Hallgato>()
            {
                new Hallgato("Nagy Anna", 20, "ABC123"),
                new Hallgato("Kovács Béla", 22, "QWERTY"),
                new Hallgato("Tóth Gergő", 21, "LONGCODE123")
            };

            foreach (var h in hallgatok)
            {
                Console.WriteLine(h);
            }

            
            List<Szemely> emberek = new List<Szemely>()
            {
                new Hallgato("Fekete Dóra", 19, "DFG456"),
                new Dolgozo("Szabó László", 35, 350000)
            };

            foreach (var ember in emberek)
            {
                ember.Bemutatkozik(); 
            }

            Console.WriteLine("\n=== Program vége ===");
        }
    }
}