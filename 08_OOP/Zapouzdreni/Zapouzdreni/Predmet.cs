using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapouzdreni
{
    internal class Predmet
    {
        private string name;
        private int price;
        private double weight;

        //veřejná položka pro změnu soukromé
        public string Name
        {
            get
            {
                return name; //vracím obsah soukromé položky
            }
            set
            {
                name = value; //vložení hodnoty na soukromou položku
            }
        }
        //short-hand public string Name {get; set;} - nesmíte v tu chvíli mít soukromou položku

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value >= 0) //aby se hodnota nastavila, musí splnit podmínku
                {
                    price = value;
                }
            }
        }

        public double Weigth
        {
            get
            {
                return weight;
            }

            set
            {
                if(value > 100)
                {
                    weight = 100;
                } else if(value < 0.1)
                {
                    weight = 0.1;
                } else
                {
                    weight = value;
                }
            }
        }

        //Shorthand Set a Get
        public string Popis { get; set; } //furt podléhá zapouzdření dat
                                          //soukromá položka pro vás není vidět

        public int ID { get; private set; } //položka je veřejná pro get (v Mainu zobrazím)
        //set je soukromý, takže musím nastavit v rámci metody uvinitř třídy

        //Konstruktor
        public Predmet()
        {
            this.ID = 10;
        }

        /* Vracení a zadávání hodnot pomocí metod
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        */
    }
}
