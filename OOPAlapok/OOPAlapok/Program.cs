using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    public class Szemely
    {
        private string nev;
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

        public override string ToString()
        {
            return $"Név: {Nev}, Életkor: {Kor}";
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