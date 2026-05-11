using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat._02._23
{
    internal class Program
    {
        class Futam
        {
            public string Datum {  get; set; }
            public string Nev { get; set; }
            public int Pozicio { get; set; }
            public int Koroksz { get; set; }
            public int Pontok { get; set; }
            public string Csapat {  get; set; }
            public string Statusz {  get; set; }

            public Futam(string sor)
            {
                string[] f = sor.Split(';');
                Datum = f[0];
                Nev = f[1];
                Pozicio = int.Parse(f[2]);
                Koroksz = int.Parse(f[3]);
                Pontok = int.Parse(f[4]);
                Csapat = f[5];
                Statusz = f[6];
            }
        }
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("schumacher.txt");
            List<Futam> futam = new List<Futam>();
            for(int i = 1; i< sorok.Length; i++)
            {
                Futam a = new Futam(sorok[i]);
                futam.Add(a);
            }

            Console.WriteLine($"1.feladat: {futam.Count} db nagydíjról található információ");

            int pont = 0;
            foreach (var f in futam)
            {
                 pont += f.Pontok;

            }
            int atlag = pont / futam.Count ;
            Console.WriteLine($"2.feladat: Átlagosan {atlag} pontot szerzett");


            int min = 102143343;
            foreach(var f in futam)
            {
                if(f.Csapat == "Mercedes" && f.Pozicio != 0 && f.Pozicio < min)
                {
                    min = f.Pozicio;
                }
            }
            Console.WriteLine($"3.feladat: A Mercedes szineiben a legjobb helyezes {min}");
            Console.WriteLine("4.feladat:");
            HashSet<string> csapatok = new HashSet<string>();
            foreach(var f in futam)
            {
                csapatok.Add(f.Csapat);
            }
            foreach(var cs in csapatok)
            {
                int pontok = 0; 
                foreach(var f in futam)
                {
                    if(f.Csapat == cs)
                    {
                        pontok += f.Pontok;
                    }
                }
                
                Console.WriteLine($"{cs} - {pontok}");
            }



        }
    }
}
