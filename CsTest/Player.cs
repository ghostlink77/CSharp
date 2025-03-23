using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTest
{
    class Player
    {
        private string id;
        private int currHp;

        public Player(string id = "abc", int currHp = 1000)
        {
            this.id = id;
            this.currHp = currHp;
        }
        public Player DeepCopy()
        {
            Player clone = new Player();
            clone.id = id;
            clone.currHp = currHp;
            return clone;
        }

        public void TakeDamage(int damage)
        {
            if (currHp > damage) currHp -= damage;
        }

        public void Status()
        {
            Console.WriteLine("Player ID : {0}", id);
            Console.WriteLine("Player HP : {0}", currHp);
        }
    }
}
