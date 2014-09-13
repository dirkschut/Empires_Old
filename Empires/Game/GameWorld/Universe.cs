using Empires.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empires.Game.GameWorld
{
    public class Universe
    {
        public String name;

        public int ID;

        public Universe()
        {
            ID = Objects.game.data.universeCounter;
            Objects.game.data.universeCounter++;

            Objects.game.data.galaxies.Add(new Galaxy(true));

            int amountOfGalaxies = new Random().Next(1000, 100000);
            for (int i = 0; i < amountOfGalaxies; i++)
            {
                Objects.game.data.galaxies.Add(new Galaxy(false));
            }
        }
    }
}
