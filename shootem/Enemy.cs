using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace shootem
{
    class Enemy : Entity
    {
        public Enemy(int id, Vector2 position = new Vector2(), int tid = 0) : base(id, position, tid)
        {
            Console.Out.Write("id:{id}, pos:{position}, tid:{tid}");

        }


        public void Update()
        {
            
        }
    }

    class EnemyFactory
    {
        Dictionary<int, Enemy> enemyTypes;

        public EnemyFactory()
        {
            enemyTypes = new Dictionary<int, Enemy>();

        }

        public void DefineEnemyType()
        {
            Enemy Temp = new Enemy(0);

        }
    }
}
