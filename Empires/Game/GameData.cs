using Empires.Game.GameWorld;
using Empires.IO.Packages;
using Newtonsoft.Json;
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

        [JsonIgnore]
        public Package package;

        public Double resourceModifier;
        public Double startingPopulation;

        public int universeCounter;
        public int galaxyCounter;
        public int solarSystemCounter;
        public int bodyCounter;

        public List<Universe> universes = new List<Universe>();
        public List<Galaxy> galaxies = new List<Galaxy>();
        public List<SolarSystem> solarSystems = new List<SolarSystem>();
        public List<Body> bodies = new List<Body>();
        public List<Zone> zones = new List<Zone>();
    }
}
