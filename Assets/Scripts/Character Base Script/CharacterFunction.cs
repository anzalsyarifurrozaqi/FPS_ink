using UnityEngine;

namespace Ink_Project {
    public class CharacterFunction : MonoBehaviour {
        public CharacterControl control;

        public virtual void RunFunction() {
            throw new System.NotImplementedException();
        }

        public virtual void RunFunction(CharacterControl control) {
            throw new System.NotImplementedException();
        }

        public virtual void RunFunction(Vector2 vector21) {
            throw new System.NotImplementedException();
        }

        public virtual void RunFunction(float float1, float float2) {
            throw new System.NotImplementedException();
        }

        public virtual void RunFunction(bool bool1) {
            throw new System.NotImplementedException();
        }
    }
}