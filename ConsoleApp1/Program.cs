namespace ConsoleApp1
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Udemy u = new Udemy();
            //u.See();
            /*
            Console.WriteLine("Enter the speed limit");
            u.speedlimit = Convert.ToInt32(Console.ReadLine());
            u.enterspeed();*/

            //checkup();

            //listcheckup();

            //filecheck();

            var ufields = new Understanding_fiels();
            ufields.height = 100;
            ufields.width = 120;
            ufields.dateInstalled = new DateTime(2023,01,04);

            
            
            ufields.name = "Rit";
            ufields.print();
            //ufields.work();
        }

        static void filecheck()
        {
            var pathsrc = @"D:\CA1_7sem\RateAdaptation.docx";
            var pathdest = @"D:\Hello.txt";
            //File.Copy(pathsrc, pathdest, true);
            //File.Delete(pathdest);
            
            if (File.Exists(pathdest))
            {
                var content = File.ReadAllText(pathdest);
                int no = 0;
                for(int i = 0; i < content.Length; i++)
                {
                    if (content[i]==' ' && (content[i-1]!=',' || content[i-1] != '.'))
                    {
                        no++;
                    }else if (content[i]==',' || content[i] == '.' || content[i]=='\n')
                    {
                        no++;
                    }
                }
                Console.WriteLine(no);
            }
        }
        static void checkup()
        {
            int[] arr = new int[3] { 1, 2, 3, };
            int[,] arr2 = { { 1, 2, 3, }, { 3, 4, 5,},};
            int[][] arr3 = new int[3][];
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                arr3[i] = new int[5];
            }
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr2.GetLength(0)); 
            Console.WriteLine(arr2.GetLength(1));
        }

        static void listcheckup()
        {
            List<int> arr = new List<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(45);
            List<int> list = new List<int>() { 77,88,99};

            
            arr.AddRange(new int[]{5,6,7});
            arr.AddRange(list);
            arr.RemoveAt(2);
            
            Console.WriteLine(arr.Count);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }


    }
}