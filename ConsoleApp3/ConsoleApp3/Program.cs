namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamlista = new List<int>();
            szamlista.Add(1);
            szamlista.Add(2);
            szamlista.Remove(0);
            szamlista.Insert(0, 1);
            Console.WriteLine("Első elem:" + szamlista.First());

            List<int> szamok = new List<int> {0, 2, 4, 5, 7, 8 };

            //1
            int szamlalo = 0;
            foreach(int i in szamok)
            {
                szamlalo += i;
            }
            Console.WriteLine(szamlalo);
            //2
            int paros 0;
            foreach(int i in szamok)
            {
                if (i % 2 == 0) paros++;
            }
            Console.WriteLine(paros);
            //3
            int paratlan = 0;
            foreach (var szam in szamok) ;
            {
                if (szam % 2 == 1)paratlan++;
            }
            Console.WriteLine(paratlan);
            //4
            int maxi = szamok[0];
            foreach(var szam in szamok)
            {
                if (szam < maxi) ;

            }
            Console.WriteLine("Legnyagyobb szám" + maxi);
            //5
            //6
            bool vanHarmas = szamok.Contains(3);
            if (vanHarmas) {
                Console.WriteLine("Van benne hármas"); }

            else { Console.WriteLine("Nincs benne hármas"); }

            //7
            int szorzat = szamok[0];
            foreach (var szam in szamok) {
                szorzat *= szam;
            }
            Console.WriteLine("Számok szorzata:"+ szorzat);
            //8
            bool novekvo = true;
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] < szamok[i - 1]) 
                    novekvo |= false;
                break;
            }
            Console.WriteLine("Növekszik a cucc?" + (novekvo ? "Igen":"Nem"));
            //9

            //10
            int tartalom = maxi - int.MinValue;
            Console.WriteLine($"Tartomány: {tartalom}");

            //11
        }
    }
}
