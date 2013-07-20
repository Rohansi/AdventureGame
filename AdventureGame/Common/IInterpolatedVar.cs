using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Common
{
    interface IInterpolatedVar
    {
        void PreUse(double alpha);
        void PostUse();
    }
}
