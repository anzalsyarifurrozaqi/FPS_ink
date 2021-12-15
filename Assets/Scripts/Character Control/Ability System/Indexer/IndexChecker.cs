using System.Collections.Generic;


namespace Ink_Project {
    public class IndexChecker {
        public static bool MakeTransition(CharacterControl control, List<TransitionConditionType> transitionConditionTypes) {
            foreach (TransitionConditionType c in transitionConditionTypes) {
                CheckConditionBase check = GetConditionChecker.GET(c);

                if (!check.MeetCondition(control)) {
                    return false;
                }
            }
            return true;
        }

        public static bool NotCondition (CharacterControl control, List<TransitionConditionType> transitionConditionTypes) {
            foreach (TransitionConditionType c in transitionConditionTypes) {
                CheckConditionBase check = GetConditionChecker.GET(c);

                if (check.MeetCondition(control))
                {
                    return true;
                }                
            }

            return false;
        }
    }
}