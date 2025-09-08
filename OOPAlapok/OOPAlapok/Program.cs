using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    public class Szemely
    {
        
        
        public string nev = "István";
        public int kor = 22;

        public Szemely(string Nev, int Kor) 
        {
            this.nev = Nev;
            this.kor = Kor;
        }


        public string Kiir()
        {
            return $"A személy neve {nev} és életkor: {kor}";
        }
    }
    


    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely("Ibolya",25);
            Console.WriteLine($"A személy neve:  { person.nev} és életkora: {person.kor}");
        }
    }
}
