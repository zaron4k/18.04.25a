using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string lastName) : base(lastName) { }
        public override void Study()
        {
            Console.WriteLine($"{LastName} учится хорошо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{LastName} читает книги редко!");
        }
        public override void Write()
        {
            Console.WriteLine($"{LastName} пишет быстро, красиво, есть ошибки!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{LastName} отдыхает спя!");
        }
    }
}
