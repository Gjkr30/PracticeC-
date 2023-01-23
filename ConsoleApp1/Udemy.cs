using System;

namespace ConsoleApp1
{
    public class Udemy
    {
        private int demerit;
        public int speedlimit = 0;
        public void See()
        {
            Console.WriteLine("Enter the value");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((num >= 1 && num <= 10) ? "Valid" : "Invalid");
        }
        
        public void max()
        {
            Console.WriteLine("enter the two values with spaces in between");
            string[] arr = Console.ReadLine().Split(' ');
     
            int a = Convert.ToInt32(arr[0]);
            int b = Convert.ToInt32(arr[1]);
            Console.WriteLine((a>b)?a:b);
        }
        public void enterspeed()
        {
            Console.WriteLine("Enter the speed");
            int speed = Convert.ToInt32(Console.ReadLine());
            if(speed > speedlimit)
            {
                
                int overspeed = speed - speedlimit;
                int fine = overspeed / 5 + 1;
                demerit += fine;
                if (demerit > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points {0} ", demerit);
                }
                
            }
        }


    }
}
