using System.Net.Http.Headers;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //egszerű típusok

            int egesz = 10;
            char karakter = '5';
            double nagyvalos = 3.1;
            bool logikai = true;


            //összetett típusok

            //tömb típus
            int[] egeszek;
            int[] masiktomb = { 1, 2, 3, 6 };
            for (int i = 0; i < masiktomb.Length; i++)
            {
                Console.WriteLine(masiktomb[i] + " ");
            }
            int[] masiktomb2 = new int[10];
            Console.WriteLine("Csupa nulla?");
            for (int i = 0; i < masiktomb2.Length; i++)
            {
                Console.WriteLine(masiktomb2[i] + " ");
            }
            //masiktomb2-be másold a másik tömb elemit.
            for (int i = 0; i < masiktomb2.Length; i++)
            {
                masiktomb2[i] = masiktomb[i];
            }
            Console.WriteLine("Másolás után ");
            for (int i = 0; i < masiktomb2.Length; i++)
            {
                Console.WriteLine(masiktomb2[i] + " ");
            }
            //String mint tömb
            String szoveg = "Az almafán alma tere.";
            String masikszoveg = new string("Másik mondat");
            //1.Hány 'a' betű van a szöveg-ben?
            int szamlalo = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] == 'a')
                {
                    szamlalo++;
                }

            }
            Console.WriteLine(szamlalo);
            //2.Hány karakterbő áll a szöveg?
            Console.WriteLine(szoveg.Length);
            //3.Hány szóbol áll? (szóköz választja el a szavakat)
            int szo = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] == ' ')
                    szo++;
            }
            Console.WriteLine("Enyi szó van:{0}", szo);
            //4.Van nagybetű a szoveg-ben?
            bool nagybetu = false;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (char.IsUpper(szoveg[i]))
                    nagybetu |= true;
                break;
            }
            if (nagybetu)
                Console.WriteLine("Van nagybetű a szövegben");
            else
                Console.WriteLine("Nincs nagybetű");
            //5.Cseréld ki az a baetűt *-ra és jelenítsd meg.

            string csere = szoveg.Replace('a', '*');
            Console.WriteLine("Cserélt szöveg" + csere);

            //6.Csak az első 10 betűt jelenítsd meg, visszafele!

            for (int i = 0; i <= 10; i--)
                Console.WriteLine(szoveg[i]);

            //7.Melyik a leghosszabb szó?
            string[] szavak = szoveg.Split(" ");
            string leghosszabb = "";

            foreach (var szos in szavak)
            {
                if (szos.Length > leghosszabb.Length)
                    leghosszabb = szos;
            }
            Console.WriteLine("\nleghosszabb szo: {0}", leghosszabb);
            //8.A kisbetűkböl Nagyot a Nagyokból kicsit csinálj!
            string modositottSzoveg = szavak[0];
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (char.IsLower(szoveg[i]))
                    modositottSzoveg += (szoveg[i].ToString().ToUpper());
                else if (char.IsUpper(szoveg))
            }
            //9. 
            for (int i = 1; i < szoveg[i]; i += 2)
            {
                Console.WriteLine(szoveg[i]);
            }

            //10
            bool vanbenne = false;
            string irasjelek = ",;:.?!";
            foreach (var c in szoveg)
            {
                if (szoveg.Contains(c))
                {
                    vanbenne = true;
                }
            }
            Console.WriteLine(vanbenne ? "Van benne írásjel" : "Nincs benne");

            //11
            string maganhangzok = "aáeéiíoóöőuúüűAÁEÉIÍOÓÖŐUÚÜŰ";
            string massalhangzok = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

            int hanymagan = 0;
            int hanymassal = 0;

            for (int i = 0; i < szoveg.Length; i++)
            {
                if (maganhangzok.Contains(szoveg[i])) hanymagan++;
                if (massalhangzok.Contains(szoveg[i])) hanymassal++;
            }

            Console.WriteLine(hanymagan);
            Console.WriteLine(hanymassal);

            //Osztály típius
        }
    }
}
