using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Wifi
    {
         
        public DateTime dateInstalled { get; set; }
        public float packValue { get; set; }

        public string name = "Madan";

        protected string lname = "Mohan";
        protected void work()
        {
            if((DateTime.Now - dateInstalled).Days <= 30)
            {
                Console.WriteLine("Started Working");
            }
            else
            {
                Console.WriteLine("Pack Expired please recharge");
            }
        }
    }
}
