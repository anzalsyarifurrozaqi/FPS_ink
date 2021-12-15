using UnityEngine;

namespace Ink_Project
{
    public abstract class CharacterAbility : ScriptableObject
    {
        public abstract void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1);
        public abstract void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1);
        public abstract void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo1);
    }
}