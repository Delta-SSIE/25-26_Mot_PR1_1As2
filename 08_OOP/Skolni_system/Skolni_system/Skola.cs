using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolni_system
{
    internal class Skola
    {
        private string jmeno;
        public Student[] studenti;
        private int pocetStud;

        public Skola(string jmeno)
        {
            this.jmeno = jmeno;
            this.studenti = new Student[0];
            this.pocetStud = 0;
        }

        public void PridejStudenty(int pocet)
        {
            for (int i = 0; i < pocet; i++)
            {
                Array.Resize(ref studenti, studenti.Length + 1);
                studenti[studenti.Length - 1] = new Student(pocetStud);
                pocetStud++;
            }
        }

        public void VypisStudenty()
        {
            Console.WriteLine("-------------");
            for (int i = 0; i < studenti.Length; i++)
            {
                studenti[i].PredstavSe();
            }
            Console.WriteLine("-------------");
        }

        public void DejZnamkuStudentovi(int id, int znamka, int vaha, string predmet)
        {
            studenti[id - 1].DejSiZnamku(znamka, vaha, predmet);
        }
    }
}
