using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.Common
{
    public class InterpolatedFloat : IInterpolatedVar
    {
        public void PreUse(double alpha)
        {
            if (Value != curValue)
            {
                prevValue = curValue;
                curValue = Value;
            }

            Value = (float)((curValue * alpha) + (prevValue * (1 - alpha)));
        }

        public void PostUse()
        {
            Value = curValue;
        }

        public float Value;
        private float curValue;
        private float prevValue;
    }
}
