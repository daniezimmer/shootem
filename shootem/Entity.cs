using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shootem
{
    abstract class Entity
    {
        public Vector2 position;
        public int textureId;    


        public Entity(Vector2 position, int tid)
        {
            this.position = position;
            this.textureId = tid;
        }
        
        public Entity()
        {
            this.position = Vector2.Zero;
            this.textureId = 0;
        }

    }

    class EntityFactory
    {


    }
}
