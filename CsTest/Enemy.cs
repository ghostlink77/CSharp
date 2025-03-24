using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTest
{
    class Enemy
    {
        public virtual void TakeDamage(int damage)
        {
            Console.WriteLine($"Enemy: {damage}만큼 체력 감소");
        }
    }

    class Slime: Enemy
    {
        public override void TakeDamage(int damage)
        {
            Console.WriteLine($"Slime: {damage}만큼 체력 감소");
        }
    }
    class Dragon: Enemy
    {
        public override void TakeDamage(int damage)
        {
            Console.WriteLine($"Dragon: {damage}만큼 체력 감소");
        }
    }
    class Goblin : Enemy
    {
        public override void TakeDamage(int damage)
        {
            Console.WriteLine($"Goblin: {damage}만큼 체력 감소");
        }
    }
}
