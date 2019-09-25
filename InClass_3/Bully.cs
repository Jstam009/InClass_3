using System;
using System.Collections.Generic;
using System.Text;

namespace InClass_3
{
    class Bully : Nerd
    {
        public string bullyName = "Shreya";

        public void getBullied()
        {
            Console.WriteLine("The nerd " + nerdName + " gets bullied by " + bullyName);
        }
    }
}
