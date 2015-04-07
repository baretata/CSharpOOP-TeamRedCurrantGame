namespace GameEngine
{
    using System;
    using System.Collections.Generic;

    using Models;
    using Models.Interfaces;
    using Models.Gear.Items;
    using Models.Spells;

    public class MainProgramClass
    {
        public static void Main()
        {
            Engine engine = InitializeEngine();
            StartOperations(engine);
        }

        private static void StartOperations(Engine engine)
        {
            string input = Console.ReadLine();
            while (input.ToLower() != "quit")
            {
                engine.ParseCommand(input);
                input = Console.ReadLine();
            }
        }

        private static Engine InitializeEngine()
        {
            return new Engine();
        }
    }
}
