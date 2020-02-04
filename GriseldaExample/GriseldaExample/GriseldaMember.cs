using System;
using System.Collections.Generic;
using System.Text;

namespace GriseldaExample
{
    class GriseldaMember : Rapper
    {
        string name;

        public GriseldaMember(string name)
        {
            _name = name;
            haveBars = true;
            canSing = false;
        }
    }
}
