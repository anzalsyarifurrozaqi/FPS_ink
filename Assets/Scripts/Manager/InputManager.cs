using UnityEngine;

namespace Ink_Project {
    public enum InputKeyType {
        KEY_MOVE_UP,
        KEY_MOVE_DOWN,
        KEY_MOVE_RIGHT,
        KEY_MOVE_LEFT,


        NONE
    }

    public class InputManager : Singleton<InputManager> {
        public PlayerInput PlayerInput;
        public Vector2 Move;
        public Vector2 Look;
        public bool Aim;
        public bool Shot;

        public void LoadPlayerInput() {
            Object obj = Resources.Load<GameObject>("PlayerInput");
            GameObject p = Instantiate(obj) as GameObject;
            PlayerInput = p.GetComponent<PlayerInput>();
        }
    }
}