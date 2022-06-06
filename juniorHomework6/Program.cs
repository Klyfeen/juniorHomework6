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
            int picturesInRow = 3;
            int filledRowsOfPictures = albumPictures / picturesInRow;
            int extraPictures = albumPictures % picturesInRow;

            Console.WriteLine($"Количество заполненных рядов картинками: {filledRowsOfPictures}");
            Console.WriteLine($"Количество картинок сверх меры: {extraPictures}");
        }
    }
}
