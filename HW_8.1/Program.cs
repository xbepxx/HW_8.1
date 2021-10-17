using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Name/Desktop/Обучение/Автоматизация BIM/Модуль 1";
            string [] cat = Directory.GetDirectories(path);
            foreach (string s in cat)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
