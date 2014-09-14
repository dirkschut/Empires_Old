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

        public Double x;
        public Double y;
        public Double z;

        public Double xSpeed;
        public Double ySpeed;
        public Double zSpeed;

        public int ID;
        public int universe;

        public Boolean generated;

        public Galaxy(Boolean generate, int universe)
        {
            this.ID = Objects.game.data.galaxyCounter;
            Objects.game.data.galaxyCounter++;
            this.universe = universe;
            this.name = Objects.game.data.package.getRandomObjectName();

            Random rand = new Random();
            
            this.x = Calc.genMod() * Finals.UNIVERSE_SIZE;
            this.y = Calc.genMod() * Finals.UNIVERSE_SIZE;
            this.z = Calc.genMod() * Finals.UNIVERSE_SIZE;

            this.xSpeed = Calc.genMod() * Finals.UNIVERSE_SPEED;
            this.ySpeed = Calc.genMod() * Finals.UNIVERSE_SPEED;
            this.zSpeed = Calc.genMod() * Finals.UNIVERSE_SPEED;

            if (generate)
            {
                Objects.game.data.solarSystems.Add(new SolarSystem(true, ID));
                int numberOfSolarSystems = rand.Next(Finals.MIN_SOLARSYSTEMS, Finals.MAX_SOLARSYSTEMS);
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
