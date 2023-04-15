using Logic.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ManagerFactory
{
    public static class CharacterManagerFactory
    {
        public static CharacterManager CreateCharacterManager(ICharacterRepository characterRepository)
        {
            return new CharacterManager(characterRepository);
        }
    }
}
