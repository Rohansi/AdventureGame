using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGame.World
{
    public class World
    {
        public World()
        {
            Entities = new List<Entity>();
        }

        public void Update(double dt)
        {
            foreach (var e in Entities)
            {
                e.Update(dt);
            }
        }

        public void Render(double alpha)
        {
            foreach (var e in Entities)
            {
                e.Render(alpha);
            }
        }

        public List<Entity> Entities;
    }
}
