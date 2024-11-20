using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemoteControl
{
    internal class WriteLine <T>
    {
        private T value;

        public WriteLine (T value)
        {
            this.value = value;
        }

        public void Write()
        {
            Console.WriteLine($"The Output: {this.value}");
        }
    }
}
