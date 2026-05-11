using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV
{
    internal class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public int score { get; set; }

        public void Introduction()
        {
            Console.WriteLine($"{this.username} with {this.score} score!");
        }
    }
}
