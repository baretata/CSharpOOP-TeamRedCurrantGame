namespace GameEngine
{
    using System;
    using System.Collections.Generic;

    using GameEngine.Factories;
    using GameEngine.Interfaces;

    using Models;                   
    using Models.Creatures;
    using Models.Creatures.Interfaces;
    using Models.Gear.Interfaces;
    using Models.Gear.Items;
    using Models.Gear.Weapons;

    public class Engine
    {
        public static readonly Random rnd = new Random();

        private ICreatureFactory creatureFactory;
        private IGearFactory gearFactory;

        public Engine()
        {
            this.creatureFactory = new CreatureFactory();
            this.gearFactory = new GearFactory();
        }
    }
}
