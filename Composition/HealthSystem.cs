using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class HealthSystem
    {
        public int health;

        public HealthSystem(int initHealth)
        {
            health = initHealth;
        }

        public void TakeDamage(int hp)
        {
            health -= hp;
        }

        public void Heal(int hp)
        {
            health += hp;
        }
    }
}
