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
        public int size;
        public int distanceFromCentre;

        public Double position;
        public Double speed;

        public Body(Boolean generate, int solarSystem, int type)
        {
            this.ID = Objects.game.data.bodyCounter;
            Objects.game.data.bodyCounter++;
            this.type = type;

            Random rand = new Random();

            switch (type)
            {
                case TYPE_STAR:
                    distanceFromCentre = 0;
                    position = 0;
                    speed = 0;
                    size = rand.Next(10000, 100000);
                    break;
                case TYPE_PLANET:
                    distanceFromCentre = rand.Next(100, 10000);
                    position = rand.NextDouble() * 360;
                    speed = rand.NextDouble();
                    size = rand.Next(100, 10000);
                    break;
                case TYPE_ASTROID:
                    distanceFromCentre = rand.Next(100, 10000);
                    position = rand.NextDouble() * 360;
                    speed = rand.NextDouble();
                    size = rand.Next(1, 100);
                    break;
            }
        }
    }
}
