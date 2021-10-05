using System.Collections.Generic;


namespace Ink_Project
{
    [System.Serializable]
    public class AbilityData
    {
        public Dictionary<CharacterAbility, int> CurrentAbilities =
            new Dictionary<CharacterAbility, int>();
    }
}