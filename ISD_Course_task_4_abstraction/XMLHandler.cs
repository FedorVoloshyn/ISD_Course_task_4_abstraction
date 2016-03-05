using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_4_abstraction
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML flie opened.");
        }
        public override void Change()
        {
            Console.WriteLine("XML flie changed.");
        }
        public override void Save()
        {
            Console.WriteLine("XML flie saved.");
        }
        public override void Create()
        {
            Console.WriteLine("XML flie created.");
        }
    }
}
