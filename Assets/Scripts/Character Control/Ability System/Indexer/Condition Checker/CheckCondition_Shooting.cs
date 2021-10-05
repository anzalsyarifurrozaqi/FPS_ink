using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class CheckCondition_Shooting : CheckConditionBase {
        public override bool MeetCondition(CharacterControl control) {            
            if (control.Attack) {
                return true;
            }

            return false;
        }
    }
}