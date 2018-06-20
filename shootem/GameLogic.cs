using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shootem
{
    class GameLogic : IEnumerable
    {
        EntityFactory entityFactory;
        EnemyFactory enemyFactory;

        List<Projectile> enemyBullets;
        List<Projectile> playerBullets;
        public List<Enemy> enemyList;
        Player playerObject;

        public GameLogic()
        {
            enemyBullets = new List<Projectile>();
            playerBullets = new List<Projectile>();
            enemyList = new List<Enemy>();


            entityFactory = new EntityFactory();
            enemyFactory = new EnemyFactory(entityFactory, enemyList);



            enemyFactory.DefineEnemyType();
            enemyFactory.SpawnType(0);
            enemyFactory.SpawnType(1);
            enemyFactory.SpawnType(2);
            enemyFactory.SpawnType(3);
        }


        public void Update()
        {
            foreach (Enemy e in enemyList)
            {
                foreach (Projectile p in playerBullets)
                {
                    Collide(e, p);

                }
            }

            foreach (Projectile p in enemyBullets)
            {
                Collide(playerObject, p);
            }
        }

        private void Collide(Entity e1, Entity e2)
        {

        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
    }
}
