using Empires.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empires.Game.GameWorld
{
    public class Galaxy
    {
        public String name;

        public int ID;

        public Galaxy(Boolean playerUniverse)
        {
            this.ID = Objects.game.data.galaxyCounter;
            Objects.game.data.galaxyCounter++;
        }
    }
}
