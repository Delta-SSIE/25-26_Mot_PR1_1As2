using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uvod_Garaz
{
    internal class Auto
    {
        //Atributy/Vlastnost (veřejné)
        public int pocetKol;
        public string SPZ;
        public string[] pasazeri;

        //Metoda
        public void PredstavSe()
        {
            Console.WriteLine($"Tohle auto má {this.pocetKol} kola a má SPZ: {this.SPZ}");
        }

        public void VypisPasazery()
        {
            Console.WriteLine($"V autě s SPZ: {this.SPZ} jedou následující lidi:");
            for (int i = 0; i < this.pasazeri.Length; i++)
            {
                Console.WriteLine(this.pasazeri[i]);
            }
        }

    }
}
