using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    class RemoteControl
    {
        private Command[] onCommands;
        private Command[] offCommands;

        public RemoteControl(int slotsCount)
        {
            onCommands = new Command[slotsCount];
            offCommands = new Command[slotsCount];
            
            for (int i = 0; i < slotsCount; i++)
            {
                onCommands[i] = new NoCommand();
                offCommands[i] = new NoCommand();
            }

        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void setCommand(int slot, Command onButtonCommand, Command offButtonCommand)
        {
            onCommands[slot] = onButtonCommand; 
            offCommands[slot] = offButtonCommand;
        }
    }
}
