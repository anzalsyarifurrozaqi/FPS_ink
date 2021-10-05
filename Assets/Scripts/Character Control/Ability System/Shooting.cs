using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    [CreateAssetMenu(fileName = "New State", menuName = "INK_Project/CharacterAbilities/Shooting")]
    public class Shooting : CharacterAbility {
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            characterState.control.RunFunction(typeof(Aim));
        }       

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            
        }
        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1) {
            
        }
    }
}