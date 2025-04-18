using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pupil1 = new ExcelentPupil("Даниил");
            var pupil2 = new GoodPupil("Витя");
            var pupil3 = new BadPupil("Максим");
            ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);
            classRoom.DisplayInfo();
            Console.Read();
        }
    }
}
