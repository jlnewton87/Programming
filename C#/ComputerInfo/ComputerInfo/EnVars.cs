using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyComputer
{
    class EnVars
    {
        public System.Collections.IDictionary GetVars()
        {
            System.Collections.IDictionary envars = Environment.GetEnvironmentVariables();
            return envars;
        }
    }
}
