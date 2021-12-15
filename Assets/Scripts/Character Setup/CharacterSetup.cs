using UnityEngine;

namespace Ink_Project {
    public enum CharacterType {
        PLAYER,
        ENEMY
    }
    public class CharacterSetup : MonoBehaviour {
        [Space(15)] public CharacterType CharacterType;                
    }
}