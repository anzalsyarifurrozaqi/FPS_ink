using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class CharacterFunctionProcessor : MonoBehaviour {
        public Dictionary<System.Type, CharacterFunction> DicFunction = new Dictionary<System.Type, CharacterFunction>();
        public CharacterFunctionList FunctionListType;

        private void Awake() {
            if (FunctionListType != null) {
                List<System.Type> function = FunctionListType.GetList();

                foreach (System.Type t in function) {
                    AddFunction(t);
                }
            }
            else {
                Debug.Log($"Loading Default Character Function {this.transform.root.gameObject.name}");
                SetDefaultFunction();
            }

            CharacterControl control = this.gameObject.GetComponentInParent<CharacterControl>();
            control.InitalizeCharacter();
        }

        void SetDefaultFunction() {
            AddFunction(typeof(InitCharacter));
            AddFunction(typeof(FaceForward));
            AddFunction(typeof(MoveTransformForward));
            AddFunction(typeof(Aim));
            AddFunction(typeof(MoveTransformAim));
            AddFunction(typeof(Shoot));
        }

        void AddFunction(System.Type type) {
            if (type.IsSubclassOf(typeof(CharacterFunction))) {
                GameObject obj = new GameObject();
                obj.transform.parent = this.transform;
                obj.transform.localPosition = Vector3.zero;
                obj.transform.localRotation = Quaternion.identity;

                CharacterFunction f = obj.AddComponent(type) as CharacterFunction;
                DicFunction.Add(type, f);

                f.control = this.transform.root.gameObject.GetComponent<CharacterControl>();

                obj.name = type.ToString().Replace("Ink_Project.", "");
            }
        }
    }
}