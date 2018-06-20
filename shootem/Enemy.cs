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
        public Enemy() : base()
        {

        }

        public Enemy(Vector2 initialPosition, int textureId) : base(initialPosition, textureId)
        {

        }
        
        //TODO: Insert movement pattern
        //TODO: Insert attack pattern
        //TODO: Collision?


        public void Update()
        {
            
        }
    }

    class EnemyFactory
    {
        EntityFactory entityFactory;
        List<Enemy> enemyList;
        Dictionary<int, Enemy> enemyTypes;

        public EnemyFactory(EntityFactory entityFactory,List<Enemy> enemyList)
        {
            this.entityFactory = entityFactory;
            this.enemyList = enemyList;
            enemyTypes = new Dictionary<int, Enemy>();

        }

        public void DefineEnemyType()
        {
            enemyTypes.Add(0, new Enemy(new Vector2(40, 40), 0));
            enemyTypes.Add(1, new Enemy(new Vector2(100, 100), 0));
            enemyTypes.Add(2, new Enemy(new Vector2(100, 200), 0));
            enemyTypes.Add(3, new Enemy(new Vector2(200, 150), 0));
        }

        public void SpawnType(int i)
        {
            enemyList.Add(enemyTypes[i]);
        }
    }
}
