using UnityEngine;

namespace Ink_Project {
    public class InitCharacter : CharacterFunction {
        public override void RunFunction(CharacterControl control) {
            control.CharacterSetup = control.GetComponentInChildren<CharacterSetup>();
            control.CharacterUpdateProcessor = control.GetComponentInChildren<CharacterUpdateProcessor>();
            control.CharacterQueryProcessor = control.GetComponentInChildren<CharacterQueryProcessor>();
            control.CharacterFunctionProcessor = control.GetComponentInChildren<CharacterFunctionProcessor>();

            RegisterCharacter();
            InitCharacterStates(control.ANIMATOR);
        }

        void RegisterCharacter() {
            if (!CharacterManager.Instance.Characters.Contains(control)) {
                CharacterManager.Instance.Characters.Add(control);
            }            
        }

        void InitCharacterStates(Animator animator) {
            CharacterState[] characterStates = animator.GetBehaviours<CharacterState>();
            //Debug.Log(characterStates.Length);

            foreach (CharacterState c in characterStates) {                
                c.control = control;
            }
        }
    }
}