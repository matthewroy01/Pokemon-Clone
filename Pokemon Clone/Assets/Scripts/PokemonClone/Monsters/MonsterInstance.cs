using UnityEngine;

namespace PokemonClone.Monsters
{
    public class MonsterInstance : MonoBehaviour
    {
        private MonsterDefinition _monsterDefinition;

        public MonsterInstance(MonsterDefinition monsterDefinition)
        {
            _monsterDefinition = monsterDefinition;
        }
    }
}