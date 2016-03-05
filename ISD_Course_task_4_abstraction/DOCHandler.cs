using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_4_abstraction
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC flie opened.");
        }
        public override void Change()
        {
            Console.WriteLine("DOC flie changed.");
        }
        public override void Save()
        {
            Console.WriteLine("DOC flie saved.");
        }
        public override void Create()
        {
            Console.WriteLine("DOC flie created.");
        }
    }
}
