using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_kecskek_es_a_kocsi
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sz = 0;
            int[] gyozelmek = new int[100000000];
            var lista = new List<int>();

            while (true)
            {
                if (gyozelem() == true)
                {
                    //gyozelmek[sz] = 1;
                    lista.Add(1);
                    //sz++;
                }
                else
                {
                    //gyozelmek[sz] = 0;
                    lista.Add(0);
                    //sz++;
                }

               // Console.Clear();
                //double szum = 0;
                /*for (int i = 0; i <= sz; i++)
                {
                    szum += gyozelmek[i];
                }

                double arany = szum / (sz);*/

                double arany = lista.Average();

                Console.WriteLine(arany);
            }
        }

        static bool gyozelem()
        {
            int megmutat;
            bool[] valasztek = new bool[3];

            Random ran = new Random();

            valasztek[ran.Next(0, 3)] = true;

            int megjelol = ran.Next(0, 3);

            do
            {
                megmutat = ran.Next(0, 3);
            } while (megmutat == megjelol || valasztek[megmutat] == true);

            int valasztas = 3 - (megjelol + megmutat);

            //Console.WriteLine("Ezt választottam: {0}\n Ez a tömb értékei: {1}{2}{3}", valasztas, valasztek[0], valasztek[1], valasztek[2]);

            if (valasztek[valasztas] == true)
            { return true; }
            else
            { return false; }
        }
    }
}
