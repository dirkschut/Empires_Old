using Empires.IO;
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

            Objects.game.data.galaxies.Add(new Galaxy(true, ID));

            int amountOfGalaxies = new Random().Next(Finals.MIN_GALAXIES, Finals.MAX_GALAXIES);
            for (int i = 0; i < amountOfGalaxies; i++)
            {
                Objects.game.data.galaxies.Add(new Galaxy(false, ID));
            }
        }
    }
}
