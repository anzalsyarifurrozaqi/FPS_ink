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