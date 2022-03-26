using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ArgInterp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading Args");
            Console.WriteLine("Saving to:" +Environment.CurrentDirectory + @"\args.txt");
            File.WriteAllLines(Environment.CurrentDirectory + @"\args.txt", args);

        }
    }
}
