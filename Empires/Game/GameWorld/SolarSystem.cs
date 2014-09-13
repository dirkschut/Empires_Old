using Empires.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empires.Game.GameWorld
{
    public class SolarSystem
    {
        public String name;

        public Boolean generated;

        public int ID;
        public int galaxy;

        public SolarSystem(Boolean generate, int galaxy)
        {
            this.ID = Objects.game.data.solarSystemCounter;
            Objects.game.data.solarSystemCounter++;
            this.galaxy = galaxy;
        }
    }
}
