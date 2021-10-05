using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public enum CharacterType
    {
        PLAYER,
        ENEMY
    }
    public class CharacterSetup : MonoBehaviour
    {
        [Space(15)] public CharacterType CharacterType;
    }
}