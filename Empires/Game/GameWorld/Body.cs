using Empires.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empires.Game.GameWorld
{
    public class Body
    {
        public const int TYPE_STAR = 0;
        public const int TYPE_PLANET = 1;
        public const int TYPE_ASTROID = 2;

        public String name;

        public Boolean Generated;

        public int solarSystem;
        public int ID;
        public int type;

        public Body(Boolean generate, int solarSystem, int type)
        {
            this.ID = Objects.game.data.bodyCounter;
            Objects.game.data.bodyCounter++;
            this.type = type;
        }
    }
}
