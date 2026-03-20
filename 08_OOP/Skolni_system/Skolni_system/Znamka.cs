using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolni_system
{
    internal class Znamka
    {
        private int znamka;
        private int vaha;
        private string predmet;
        
        public Znamka(int znamka, int vaha, string predmet)
        {
            this.znamka = znamka;
            this.vaha = vaha; 
            this.predmet = predmet;
        }

        public string VratZnamku()
        {
            return $"Známka {this.znamka} s váhou {this.vaha} z předmětu {this.predmet}";
        }
    }
}
