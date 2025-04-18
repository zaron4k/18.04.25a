using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClassRoom
    {
        private List<Pupil> pupils;
        public ClassRoom (params Pupil[] pupils )
        {
            this.pupils = new List<Pupil> (pupils);
        }
        public void DisplayInfo()
        {
            foreach (var pupil in pupils)
                {
                Console.WriteLine($"Информация об ученике {pupil.LastName}:");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }
    }
}
