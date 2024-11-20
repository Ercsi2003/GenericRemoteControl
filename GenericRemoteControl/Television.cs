using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemoteControl
{
    internal class Television
    {
        private string brand;

        public Television(string brand) 
        {
            this.brand = brand;
        }

        public string Brand { get => brand; set => brand = value; }

        public override string ToString()
        {
            return this.brand;
        }
    }
}
