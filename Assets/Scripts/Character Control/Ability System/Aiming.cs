using UnityEngine;

namespace Ink_Project {
    [CreateAssetMenu(fileName = "New State", menuName = "INK_Project/CharacterAbilities/Aiming")]
    public class Aiming : CharacterAbility {
        float x = 0;
        float y = 0;
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            var targetValue = characterState.control.Move;
            x = Mathf.Lerp(x, targetValue.x, Time.deltaTime * 5f);
            y = Mathf.Lerp(y, targetValue.y, Time.deltaTime * 5f);            
            characterState.control.ANIMATOR.SetFloat(HashManager.Instance.ArrMainParams[(int)MainParameterType.X], x);
            characterState.control.ANIMATOR.SetFloat(HashManager.Instance.ArrMainParams[(int)MainParameterType.Y], y);            
            
        }
        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            characterState.control.ANIMATOR.SetFloat(HashManager.Instance.ArrMainParams[(int)MainParameterType.X], 0.0f);
            characterState.control.ANIMATOR.SetFloat(HashManager.Instance.ArrMainParams[(int)MainParameterType.Y], 0.0f);
        }
    }
}