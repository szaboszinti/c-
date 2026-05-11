using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga_2026_03_30
{
    internal class Program
    {
        class Kosar
        {
            public string Hazai { get; set; }
            public string Idegen { get; set; }
            public int Hazaipontok {get; set;}
            public int Idegenpontok { get; set;}
            public string Helyszin { get; set;}
            public string Idopont { get; set;}

            public Kosar(string sor)
            {
                string[] db = sor.Split(';');
                Hazai = db[0];
                Idegen = db[1];
                Hazaipontok = int.Parse(db[2]);
                Idegenpontok = int.Parse(db[3]);
                Helyszin = db[4];
                Idopont = db[5];

            }
        }
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("eredmenyek.txt");
            List<Kosar> kosar = new List<Kosar>();
            for(int i = 1; i < sorok.Length; i++)
            {
                Kosar k = new Kosar(sorok[i]);
                kosar.Add(k);
            }

            int haza = 0;
            int ide = 0;
            foreach(var k in kosar)
            {
                if (k.Hazai == "Real Madrid")
                {
                    haza++;
                }
                if(k.Idegen == "Real Madrid")
                {
                    ide++;
                }
                
            }
            Console.WriteLine($"3.feladat: Real Madrid: Hazai: {haza} Idegen: {ide}");

            bool volt = false;
            foreach(var k in kosar)
            {
                if(k.Hazaipontok == k.Idegenpontok)
                {
                    volt = true;
                }
                
            }
            if (volt)
            {
                Console.WriteLine($"4.feladat: Volt döntetlen? Igen");
            }
            else
            {
                Console.WriteLine($"4.feladat: Volt döntetlen? Nem");
            }


            string nev = " ";
            for (int i = 0;  i < kosar.Count; i++)
            {
                
                if (kosar[i].Hazai.Contains("Barcelona"))
                {
                    nev = kosar[i].Hazai;
                }
                
            }
            Console.WriteLine($"5.feladat: barcelonai csapat neve: {nev}");

            foreach(var k in kosar)
            {
                if(k.Idopont == "2004-11-21")
                {
                    Console.WriteLine($"6.feladat: {k.Hazai}-{k.Idegen} ({k.Hazaipontok}:{k.Idegenpontok})");
                }
            }



        }
    }
}
