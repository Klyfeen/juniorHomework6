using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juniorHomework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int albumPictures = 52;
            int specialZone = 3;
            int includedPictures = albumPictures / specialZone;
            int unincludedPictures = albumPictures % specialZone;

            Console.WriteLine($"Полностью заполненных рядов: {includedPictures}");
            Console.WriteLine($"Количество картинок сверх меры: {unincludedPictures}");
        }
    }
}
