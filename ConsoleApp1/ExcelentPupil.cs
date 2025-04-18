using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string lastName) : base(lastName) { }
        public override void Study()
        {
            Console.WriteLine($"{LastName} учится на отлично!");
        }
        public override void Read()
        {
            Console.WriteLine($"{LastName} читает книги с большим интересом!");
        }
        public override void Write()
        {
            Console.WriteLine($"{LastName} пишет быстро, красиво и без ошибок!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{LastName} отдыхает играя в полезные игры!");
        }
    }
}
