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

        public int x;
        public int y;
        public int z;

        public int ID;
        public int universe;

        public Boolean generated;

        public Galaxy(Boolean generate, int universe)
        {
            this.ID = Objects.game.data.galaxyCounter;
            Objects.game.data.galaxyCounter++;
            this.universe = universe;

            Random rand = new Random();
            this.x = rand.Next(-10000, 10000);
            this.y = rand.Next(-10000, 10000);
            this.z = rand.Next(-10000, 10000);

            if (generate)
            {
                Objects.game.data.solarSystems.Add(new SolarSystem(true, ID));
                int numberOfSolarSystems = rand.Next(1000, 100000);
                for (int i = 0; i < numberOfSolarSystems; i++)
                {
                    Objects.game.data.solarSystems.Add(new SolarSystem(false, ID));
                }
                generated = true;
            }
            else
            {
                generated = false;
            }
        }
    }
}
