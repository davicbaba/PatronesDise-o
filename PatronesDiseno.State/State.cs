using System;
using System.Collections.Generic;
using System.Text;

namespace PatronesDiseno.State
{
    public interface IState
    {

        bool Start(TimeSpan duration);
        bool Stop();

        bool OpenDoor();
    }
}
