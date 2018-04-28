using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_DA_I_O
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string[] files = Directory.GetFiles(@"D:\Wallpapers", "*.*", SearchOption.AllDirectories);
            Console.WriteLine("-Files in directory D:\\Wallpapers-");
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(i + 1 + "-" + files[i]);
            }
            Console.WriteLine("Select");
            do
            {
                var file = Console.ReadLine();
                if (int.TryParse(file, out number))
                {
                    if (number < 0 || number > files.Length)
                    {
                        Console.WriteLine("Incorrect number of file");
                    }
                }
                else Console.WriteLine("Number must be int32");
            } while (number < 0 || number > files.Length);
            string[] fileLines = File.ReadAllLines(files[number-1]);
            Console.WriteLine("-Content of chosen file-");
            Console.WriteLine("");
            foreach(var l in fileLines)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();
        }
    }
}
