using UnityEngine;
using UnityEngine.InputSystem;


namespace Ink_Project {
    public class InputReader : MonoBehaviour {       
        private MainInput MainInput;

        private void Awake() {
            MainInput = new MainInput();
        }

        private void OnEnable()
        {
            MainInput.Enable();
        }

        private void OnDisable()
        {
            MainInput.Disable();
        }

        public Vector2 ReadMove() {
            return MainInput.Player.MOVE.ReadValue<Vector2>();
        }

        public Vector2 ReadLook () {
            return MainInput.Player.LOOK.ReadValue<Vector2>();
        }

        public bool ReadAttack() {
            return MainInput.Player.ATTACK.triggered;
        }

        public bool ReadAim() {            
            return MainInput.Player.AIM.triggered;
        }
    }
}