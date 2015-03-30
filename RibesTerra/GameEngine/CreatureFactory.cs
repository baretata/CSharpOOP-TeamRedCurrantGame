using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using Models.Creatures;
using Models.Creatures.Interfaces;

namespace GameEngine
{
    public class CreatureFactory
    {
        public ICharacter CreateCharacter(string name, int power, int health, string gender, decimal gold)
        {
            return new Character(name, Character.InitialCharacterAttack, Character.InitialCharacterHealth,
                GenderType.Male, Character.InitialCharacterGold);
        }

        public ICreature CreateEnemy(string name, int power, int health, string gender)
        {
            return new Enemy(name, Character.InitialCharacterAttack, Character.InitialCharacterHealth,
                GenderType.Male);
        }
    }
}
