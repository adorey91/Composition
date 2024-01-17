using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    struct Point2D
    {
        public int x;
        public int y;
    }

    internal class Player
    {
        Point2D position;

        public HealthSystem healthSystem;

        public Player() 
        {
            healthSystem = new HealthSystem(100);
        }

       
    }
}
