using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\M-015\\Downloads\\Text1.txt";//путь к файлу
            string readText = File.ReadAllText(filePath);
            //Проверяем производительность вставки в обычный список
            var stopWatch = Stopwatch.StartNew();
            List<string> SimpleList = new List<string>();
            foreach (string line in readText.Split(new char[] { '\n', '\r', ' ' }))
            {
                SimpleList.Add(line);
            }
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

            //Проверяем производительность вставки в связный список
            var stopWatch1 = Stopwatch.StartNew();
            LinkedList<string> LinkedList = new LinkedList<string>();
            foreach (string line in readText.Split(new char[] { '\n', '\r', ' ' }))
            {
                LinkedList.AddLast(line);
            }
            Console.WriteLine(stopWatch1.Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}
