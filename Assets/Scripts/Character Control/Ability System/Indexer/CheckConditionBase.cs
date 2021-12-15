using UnityEngine;

namespace Ink_Project {
    public abstract class CheckConditionBase : MonoBehaviour {
        public abstract bool MeetCondition(CharacterControl control);
    }
}