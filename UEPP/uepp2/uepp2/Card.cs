using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uepp2
{
    class Card
    {
        private string name;

        public Card(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
