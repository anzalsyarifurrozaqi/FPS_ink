using UnityEngine;

namespace Ink_Project {
    [CreateAssetMenu(fileName = "New State", menuName = "INK_Project/CharacterAbilities/Shooting")]
    public class Shooting : CharacterAbility {
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            
        }       

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            if (characterState.control.Aim && characterState.control.Shot) {
                characterState.control.RunFunction(typeof(Shot));                
            }
        }
        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            
        }
    }
}