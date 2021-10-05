using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    [CreateAssetMenu(fileName = "New State", menuName = "INK_Project/CharacterAbilities/Aiming")]
    public class Aiming : CharacterAbility
    {
        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1)
        {
            characterState.control.RunFunction(typeof(Aim), true);
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1)
        {

        }
        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1)
        {
            Debug.Log("exit");
            characterState.control.RunFunction(typeof(Aim), false);
        }
    }
}