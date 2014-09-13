using Empires.Game.GameWorld;
using Empires.IO.Packages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Empires.Game
{
    public class GameData
    {
        public String name;

        public Package[] packages;

        public Double resourceModifier;
        public Double startingPopulation;

        public List<Universe> universes;
        public List<Galaxy> galaxies;
        public List<SolarSystem> solasSystems;
        public List<Body> bodies;
    }
}
