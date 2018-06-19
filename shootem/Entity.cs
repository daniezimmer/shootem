using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shootem
{
    class Entity
    {
        int entityId;
        Vector2 position;
        int textureId;    

        public Entity(int id, Vector2 position, int tid)
        {
            this.entityId = id;
            this.position = position;
            this.textureId = tid;
        }

    }

    class EntityFactory
    {
        public EntityFactory()
        {


        }



    }
}
