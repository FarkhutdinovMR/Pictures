using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictureCount = 52;
            int pictureCountInRow = 3;

            Console.WriteLine("Количество заполненных рядов: " + pictureCount / pictureCountInRow);
            Console.WriteLine("Количество оставшихся картинок: " + pictureCount % pictureCountInRow);
        }
    }
}