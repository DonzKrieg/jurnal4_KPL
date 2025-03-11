using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022330150
{
    internal class FanLaptop
    {
        private enum State { Quite, Balanced, Performance, Turbo}
        private State currentState = State.Quite;

        public void modeUp()
        {
            if (currentState == State.Quite)
            {
                currentState = State.Balanced;
                Console.WriteLine("Fan Quiet berubah menjadi Balanced");
            }
            else if (currentState == State.Balanced)
            {
                currentState = State.Performance;
                Console.WriteLine("Fan Balanced berubah menjadi Performance");
            }
            else if (currentState == State.Performance)
            {
                currentState = State.Turbo;
                Console.WriteLine("Fan Performance berubah menjadi Turbo");
            }
            else
            {
                Console.WriteLine("Fan berada dimode tertinggi");
            }
        }

        public void modeDown()
        {
            if (currentState == State.Turbo)
            {
                currentState = State.Performance;
                Console.WriteLine("Fan Turbo berubah menjadi Performance");
            }
            else if (currentState == State.Performance)
            {
                currentState = State.Balanced;
                Console.WriteLine("Fan Performance berubah menjadi Balanced");
            }
            else if (currentState == State.Balanced)
            {
                currentState = State.Quite;
                Console.WriteLine("Fan Balanced berubah menjadi Quite");
            }
            else
            {
                Console.WriteLine("Fan berada dimode terendah");
            }
        }

        public void turboShort()
        {
            if (currentState == State.Quite)
            {
                currentState = State.Turbo;
                Console.WriteLine("Fan Quite berubah menjadi Turbo");
            }
            else if (currentState == State.Turbo)
            {
                currentState = State.Quite;
                Console.WriteLine("Fan Turbo berubah menjadi Quite");
            }
            else
            {
                Console.WriteLine("Anda tidak berada dalam mode Quite ataupun Turbo");
            }
        }
    }
}
