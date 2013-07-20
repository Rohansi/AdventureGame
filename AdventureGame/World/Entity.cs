using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureGame.Common;

namespace AdventureGame.World
{
    public class Entity
    {
        public string Name;
        public InterpolatedVector Position;

        public Entity()
        {
            Name = "";
            Position = new InterpolatedVector();
            interpolatedVars = new List<IInterpolatedVar>();

            Interpolate(Position);
        }

        public void Update(double dt)
        {
            DoUpdate(dt);
        }

        public void Render(double alpha)
        {
            foreach (var v in interpolatedVars)
            {
                v.PreUse(alpha);
            }

            DoRender(alpha);

            foreach (var v in interpolatedVars)
            {
                v.PostUse();
            }
        }

        protected virtual void DoUpdate(double dt) { }
        protected virtual void DoRender(double alpha) { }

        protected void Interpolate(IInterpolatedVar var)
        {
            interpolatedVars.Add(var);
        }

        private List<IInterpolatedVar> interpolatedVars;
    }
}
