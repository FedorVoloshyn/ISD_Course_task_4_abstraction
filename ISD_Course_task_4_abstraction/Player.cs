using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_4_abstraction
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Start play!");
        }
        public void Record()
        {
            Console.WriteLine("Start record!");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stop record!");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop play!");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Pause record!");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause play!");
        }

    }
}
