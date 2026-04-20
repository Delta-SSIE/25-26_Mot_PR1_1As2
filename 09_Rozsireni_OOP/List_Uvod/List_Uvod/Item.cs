using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Uvod
{
    internal class Item
    {
        public int ID { get; private set; }

        public Item()
        {
            Random rnd = new Random();
            this.ID = rnd.Next(0, 1000001);
        }

    }
}
