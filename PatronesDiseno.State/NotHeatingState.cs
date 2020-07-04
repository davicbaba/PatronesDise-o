using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.State
{
    public class NotHeatingState : IState
    {
        private MicrowaveOven Context;
        public NotHeatingState(MicrowaveOven oven)
        {
            Context = oven;
        }
        public bool OpenDoor()
        {
            return true;
        }

        public bool Start(TimeSpan duration)
        {
            Context.ChangeState(new HeatingState(Context));

            return true;
        }

        public bool Stop()
        {
            return false;
        }
    }
}
