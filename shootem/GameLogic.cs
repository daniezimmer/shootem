using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shootem
{
    class GameLogic
    {
        EntityFactory entityFactory;
        EnemyFactory enemyFactory;

        List<Projectile> enemyBullets;
        List<Projectile> playerBullets;
        List<Enemy> enemyList;
        Player playerObject;

        public GameLogic()
        {
            enemyFactory = new EnemyFactory();
            enemyBullets = new List<Projectile>();
            playerBullets = new List<Projectile>();
            enemyList = new List<Enemy>();
        }
        

        public void Update()
        {
            foreach (Enemy e in enemyList)
            {
                foreach (Projectile p in playerBullets)
                {


                }
            }

            foreach (Projectile p in enemyBullets)
            {

            }
        }
    }
}
