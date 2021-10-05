using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    [CreateAssetMenu(fileName = "New State", menuName = "INK_Project/CharacterAbilities/TransitionIndexer")]
    public class TransitionIndexer : CharacterAbility
    {
        public int Index;
        public List<TransitionConditionType> transitionConditions = new List<TransitionConditionType>();
        public List<TransitionConditionType> not_Condition = new List<TransitionConditionType>();
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            if (IndexChecker.MakeTransition(characterState.control, transitionConditions)) {
                animator.SetInteger(HashManager.Instance.ArrMainParams[(int)MainParameterType.TransitionIndex], Index);
            }
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            if (animator.GetInteger(HashManager.Instance.ArrMainParams[(int)MainParameterType.TransitionIndex]) == 0) {
                if (IndexChecker.MakeTransition(characterState.control, transitionConditions)) {
                    if (!IndexChecker.NotCondition(characterState.control, not_Condition)) {
                        animator.SetInteger(HashManager.Instance.ArrMainParams[(int)MainParameterType.TransitionIndex], Index);
                    }
                }
            }
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            animator.SetInteger(HashManager.Instance.ArrMainParams[(int)MainParameterType.TransitionIndex], 0);            
        }               
    }
}