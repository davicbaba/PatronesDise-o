using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.State
{
    public class HeatingState : IState
    {
        private MicrowaveOven Context;

        public HeatingState(MicrowaveOven oven)
        {
            Context = oven;
        }

        public bool OpenDoor()
        {
            return false;
        }

        public bool Start(TimeSpan duration)
        {
            return false;
        }

        public bool Stop()
        {
            Context.ChangeState(new NotHeatingState(Context));

            return true;
        }
    }
}
