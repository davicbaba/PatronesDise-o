using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.State
{
    public class MicrowaveOven
    {
        private IState CurrentState;

        public MicrowaveOven()
        {
            CurrentState = new NotHeatingState(this);
        }

        public bool Start(TimeSpan duration)
        {
            Console.WriteLine("Estado Actual: " + CurrentState.GetType().Name + "- iniciar ");
            bool result = CurrentState.Start(duration);
            return result;
        }

        public bool Stop()
        {
            Console.WriteLine("Estado Actual: " + CurrentState.GetType().Name + "- detener ");

            bool result = CurrentState.Stop();
            return result;
        }

        public bool OpenDoor()
        {
            Console.WriteLine("Estado Actual: " + CurrentState.GetType().Name + "- abrir puerta ");

            bool result = CurrentState.OpenDoor();
            return result;
        }


        public void ChangeState(IState state)
        {
            CurrentState = state;
        }

    }
}
