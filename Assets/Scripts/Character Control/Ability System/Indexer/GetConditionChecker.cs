using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class GetConditionChecker : MonoBehaviour {
        static Dictionary<TransitionConditionType, CheckConditionBase> DicCheckers;
        static GameObject condition = null;

        public static CheckConditionBase GET (TransitionConditionType conditionType) {
            if (DicCheckers == null) {
                InitDic();
            }

            return DicCheckers[conditionType];
        }

        public static void InitDic() {
            DicCheckers = new Dictionary<TransitionConditionType, CheckConditionBase>();

            _Add(TransitionConditionType.Moving, typeof(CheckCondition_Moving));
            _Add(TransitionConditionType.Shooting, typeof(CheckCondition_Shooting));
            _Add(TransitionConditionType.Aiming, typeof(CheckCondition_Aiming));
        }

        static void _Add (TransitionConditionType transitionConditionType, System.Type checkConditionType) {
            if (condition == null) {
                condition = new GameObject();
                condition.name = "Condition Checker";
                condition.transform.position = Vector3.zero;
                condition.transform.rotation = Quaternion.identity;
            }

            if (checkConditionType.IsSubclassOf(typeof(CheckConditionBase))) {
                GameObject obj = new GameObject();
                obj.transform.parent = condition.transform;
                obj.transform.localPosition = Vector3.zero;
                obj.transform.localRotation = Quaternion.identity;
                obj.name = checkConditionType.ToString().Replace("Ink_Project", "");

                CheckConditionBase c = obj.AddComponent(checkConditionType) as CheckConditionBase;
                DicCheckers.Add(transitionConditionType, c);
            }
        }
    }
}