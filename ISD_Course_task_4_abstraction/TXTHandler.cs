using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_4_abstraction
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT flie opened.");
        }
        public override void Change()
        {
            Console.WriteLine("TXT flie changed.");
        }
        public override void Save()
        {
            Console.WriteLine("TXT flie saved.");
        }
        public override void Create()
        {
            Console.WriteLine("TXT flie created.");
        }
    }
}
