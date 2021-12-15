using UnityEngine;

namespace Ink_Project {
    [CreateAssetMenu(fileName = "New State", menuName = "INK_Project/CharacterAbilities/Walk")]
    public class Walk : CharacterAbility {
        public float Speed;
        public AnimationCurve SpeedGraph;

        public override void OnEnter(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            Debug.Log("Enter Walk");
        }

        public override void UpdateAbility(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {
            ControlledMove(characterState.control, stateInfo);
        }

        public override void OnExit(CharacterState characterState, Animator animator, AnimatorStateInfo stateInfo) {

        }

        private void ControlledMove(CharacterControl control, AnimatorStateInfo stateInfo) {
            if (control.Move == Vector2.zero)
                return;
            else if (control.Aim) {
                control.RunFunction(typeof(MoveTransformAim));
            }
            else {
                control.RunFunction(typeof(MoveTransformForward), Speed, SpeedGraph.Evaluate(stateInfo.normalizedTime));
                CheckForward(control);
            }            
        }

        private void CheckForward(CharacterControl control) {
            control.RunFunction(typeof(FaceForward), control.Move);
        }
    }
}