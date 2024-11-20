using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemoteControl
{
    internal class RemoteControl <T>
    {
        private T value;
        private int volume = 20;
        
        public RemoteControl(T value)
        {
            this.value = value;

        }

        public void PowerOn()
        {
            Console.WriteLine($"{this.value} is now on!");
        }

        public void PowerOff()
        {
            Console.WriteLine($"{this.value} just turned off!");
        }

        public void ChangeChannel(int channel)
        {
            Console.WriteLine($"{this.value}'s channel changed to channel {channel}!");
        }

        public void VolumeUp(int volumeChange)
        {
            this.volume += volumeChange;
            Console.WriteLine($"{this.value}'s volume changed to {volume}!");
        }

        public void VolumeDown(int volumeChange)
        {
            this.volume -= volumeChange;
            Console.WriteLine($"{this.value}'s volume changed  to {volume}!");
        }
    }
}
