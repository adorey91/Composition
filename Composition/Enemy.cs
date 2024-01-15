using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Enemy
    {
        public int x;
        public int y;
        public HealthSystem healthSystem;

        public Enemy()
        {
            healthSystem = new HealthSystem(50);
        }
    }
}
