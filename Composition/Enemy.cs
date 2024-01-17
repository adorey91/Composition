using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Enemy
    {
        Point2D position;

        public HealthSystem healthSystem;

        public Enemy()
        {
            healthSystem = new HealthSystem(50);
        }
    }
}
