using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public enum CharacterDataType
    {
        MOVE_DATA,

        COUNT
    }
    public class DatasetBase : MonoBehaviour
    {
        [SerializeField] protected string name;
        
    }
}