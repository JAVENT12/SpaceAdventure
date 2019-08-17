using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    public interface ITest // An interface for base classes to simulate inheritance from. First time trying to use one
    {
        string Name
        {
            get;
            set;
        }
    }
}
