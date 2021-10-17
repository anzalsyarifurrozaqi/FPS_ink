using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class ManualInput : CharacterUpdate {
        List<InputKeyType> UpKeys = new List<InputKeyType>();
        
        public override void OnFixedUpdate() {
            throw new System.NotImplementedException();
        }

        public override void OnLateUpdate() {
            throw new System.NotImplementedException();
        }

        public override void OnUpdate() {
            control.Move = InputManager.Instance.Move;
            control.Look = InputManager.Instance.Look;

            if (InputManager.Instance.Aim) {
                control.Aim = true;
            } 
            else {
                control.Aim = false;
            }

            if (InputManager.Instance.Shot) {
                control.Shot = true;
            }
            else {
                control.Shot = false;
            }
        }
    }
}