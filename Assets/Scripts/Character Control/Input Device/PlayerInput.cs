using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Ink_Project {
    [RequireComponent(typeof(InputReader))]
    public class PlayerInput : MonoBehaviour {
        private InputReader _inputReader;

        void Awake() {
            _inputReader = GetComponent<InputReader>();
        }

        void Update() {
            InputManager.Instance.Move = _inputReader.ReadMove();
            InputManager.Instance.Look = _inputReader.ReadLook();
            if (_inputReader.ReadAim()) {
                if (InputManager.Instance.Aim)
                    InputManager.Instance.Aim = false;
                else
                    InputManager.Instance.Aim = true;
            }            
            InputManager.Instance.Shot = _inputReader.ReadShot();
        }
    }
}