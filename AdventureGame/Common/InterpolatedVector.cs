using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Window;

namespace AdventureGame.Common
{
    public class InterpolatedVector : IInterpolatedVar
    {
        public void PreUse(double alpha)
        {
            if (Value.X != curValue.X || Value.Y != curValue.Y)
            {
                prevValue = curValue;
                curValue = Value;
            }

            Value = ((curValue * (float)alpha) + (prevValue * (1 - (float)alpha)));
        }

        public void PostUse()
        {
            Value = curValue;
        }

        public Vector2f Value;
        private Vector2f curValue;
        private Vector2f prevValue;
    }
}
