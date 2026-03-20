using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Skolni_system
{
    internal class Student
    {
        public int ID;
        private string jmeno;
        private Znamka[] znamky;

        public Student(int pocetStud)
        {
            Random gen = new Random();
            this.ID = pocetStud + 1;
            this.znamky = new Znamka[0];
            
            string[] jmena = new string[]
                        {
                            "Jan", "Petr", "Jiří", "Tomáš", "Martin",
                            "Michal", "Jakub", "Lukáš", "David", "Josef",
                            "Marek", "Pavel", "Filip", "Daniel", "Adam",
                            "Václav", "Ondřej", "Roman", "Karel", "Jaroslav",
                            "Radek", "Dominik", "Aleš", "Matěj", "Štěpán",
                            "Vojtěch", "Libor", "Milan", "Richard", "Zdeněk",
                            "Patrik", "Robert", "Stanislav", "Erik", "Eduard",
                            "Alan", "Bohumil", "Břetislav", "Hynek", "Ivan",
                            "Ladislav", "Leoš", "Marcel", "Miroslav", "Rudolf",
                            "Samuel", "Tadeáš", "Viktor", "Vilém", "Zbyšek",
                            "Anna", "Eva", "Marie", "Lucie", "Kateřina",
                            "Tereza", "Veronika", "Adéla", "Natálie", "Kristýna",
                            "Karolína", "Barbora", "Denisa", "Klára", "Nikola",
                            "Markéta", "Zuzana", "Jana", "Eliška", "Lenka",
                            "Alena", "Petra", "Hana", "Monika", "Gabriela",
                            "Simona", "Michaela", "Andrea", "Šárka", "Irena",
                            "Sabina", "Sofie", "Laura", "Stela", "Beáta",
                            "Nela", "Julie", "Magdaléna", "Dominika", "Sandra",
                            "Iveta", "Silvie", "Kamila", "Růžena", "Božena"
                        };
            this.jmeno = jmena[gen.Next(0, jmena.Length)];

        }

        public void PredstavSe()
        {
            Console.WriteLine($"Student s ID:{this.ID} se jmenuje: {this.jmeno}");
        }

        public void DejSiZnamku(int znamka, int vaha, string predmet)
        {
            Array.Resize(ref znamky, znamky.Length + 1);
            znamky[znamky.Length - 1] = new Znamka(znamka, vaha, predmet);
        }

        public void VypisZnamky()
        {
            Console.WriteLine($"Známky studenta {this.jmeno} s ID: {this.ID}:");
            for (int i = 0; i < znamky.Length; i++)
            {
                Console.WriteLine(znamky[i].VratZnamku());
            }
        }

    }
}
