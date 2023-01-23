using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Understanding_fiels:Wifi
    {
        public int height { get; set; } //private set will not allow feild to set value; 
        public int width { get; set; }

        public void print()
        {
            Console.WriteLine("{0} height and {1} width and value {2}",height,width,packValue);
            Console.WriteLine(name +" "+lname);
            work();
        }

    }
}
