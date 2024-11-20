using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemoteControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Television TV = new Television("SamsungTV");
            RemoteControl<Television> tvRemote = new RemoteControl<Television>(TV);
            tvRemote.PowerOn();
            tvRemote.ChangeChannel(32);
            tvRemote.VolumeUp(45);
            tvRemote.VolumeDown(12);
            tvRemote.PowerOff();
            Console.ReadLine();
        }
    }
}
