using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BadPupil:Pupil
    {
        public BadPupil(string lastName) : base(lastName) { }
        public override void Study()
        {
            Console.WriteLine($"{LastName} учится плохо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{LastName} не читает книги!");
        }
        public override void Write()
        {
            Console.WriteLine($"{LastName} пишет быстро, не красиво и с ошибками!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{LastName} отдыхает играя в телефон!");
        }
    }
}
