using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_02_2_Command
{
    interface Command
    {
        void Execute();
    }

    public class NoCommand : Command
    {
        public void Execute() { }
    }

    class GarageDoorUpCommand : Command
    {
        protected GarageDoor garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.up();
        }
    }
    class GarageDoorDownCommand : Command
    {
        protected GarageDoor garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.down();
        }
    }

    class LightOnCommand : Command
    {
        protected Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.on();
        }
    }
    class LightOffCommand : Command
    {
        protected Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.off();
        }
    }

    class TVsetInputChannelCommand : Command
    {
        protected TV tv;

        public TVsetInputChannelCommand(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.setInputChannel();
        }
    }
    class TVOnCommand : Command
    {
        protected TV tv;

        public TVOnCommand(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.on();
        }
    }
    class TVOffCommand : Command
    {
        protected TV tv;

        public TVOffCommand(TV tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            tv.off();
        }
    }

    class StereoOffCommand : Command
    {
        protected Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.off();
        }
    }
    class StereoSetCdCommand : Command
    {
        protected Stereo stereo;

        public StereoSetCdCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.on();
            stereo.setCd();
            stereo.setVolume(11);
        }
    }
    class StereoOnWithCDCommand : Command
    {
        private Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }
        public void Execute()
        {
            stereo.on();
            stereo.setCd();
            stereo.setVolume(11);
        }
    }
}
