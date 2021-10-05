using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class CheckCondition_Moving : CheckConditionBase {
        public override bool MeetCondition(CharacterControl control) {
            if (control.Move != Vector2.zero) {
                return true;
            }
            return false;
        }
    }
}