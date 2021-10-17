using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class CharacterControl : MonoBehaviour {
        [Header("Input")]
        public Vector2 Move;
        public Vector2 Look;
        public bool Aim;
        public bool Shot;

        [Header("SupbComponens")]
        public CharacterSetup CharacterSetup;
        public CharacterFunctionProcessor CharacterFunctionProcessor;
        public CharacterUpdateProcessor CharacterUpdateProcessor;
        public CharacterQueryProcessor CharacterQueryProcessor;

        public Dataset DATASET {
            get {
                if (_dataset == null) {
                    _dataset = this.gameObject.GetComponent<Dataset>();
                    _dataset.InitDataset();
                }

                return _dataset;
            }
        }

        private Dataset _dataset = null;

        public Rigidbody RIGID_BODY {
            get {
                return _rigidBody;
            }
        }

        private Rigidbody _rigidBody = null;

        public Animator ANIMATOR {
            get {
                if (_animator == null) {
                    _animator = this.gameObject.GetComponentInChildren<Animator>();
                }

                return _animator;
            }
        }

        private Animator _animator = null;

        public BoxCollider BOX_COLLIDER {
            get {
                return _boxCollider;
            }
        }

        private BoxCollider _boxCollider = null;
        public CharacterUpdate GetUpdater(System.Type UpdaterType) {
            if (CharacterUpdateProcessor.DicUpdaters.ContainsKey(UpdaterType)) {
                return CharacterUpdateProcessor.DicUpdaters[UpdaterType];
            }
            else {
                return null;
            }
        }

        public void InitalizeCharacter() {
            RunFunction(typeof(InitCharacter), this);

            CharacterUpdateProcessor.InitUpdaters();
        }

        public void CharacterUpdate() {
            CharacterUpdateProcessor.RunCharacterUpdate();
        }

        public void CharacterFixedUpdate() {
            CharacterUpdateProcessor.RunCharacterFixedUpdate();
        }

        public void CharacterLateUpdate() {
            CharacterUpdateProcessor.RunCharacterLateUpdate();
        }
        
        public void RunFunction(System.Type characterFunctionType) {
            CharacterFunctionProcessor.DicFunction[characterFunctionType].RunFunction();
        }
        public void RunFunction(System.Type characterFunctionType, CharacterControl control) {
            if (CharacterFunctionProcessor == null) {
                CharacterFunctionProcessor = this.gameObject.GetComponentInChildren<CharacterFunctionProcessor>();
            }
            CharacterFunctionProcessor.DicFunction[characterFunctionType].RunFunction(control);
        }

        public void RunFunction(System.Type characterFunctionType, Vector2 vector21) {
            CharacterFunctionProcessor.DicFunction[characterFunctionType].RunFunction(vector21);
        }

        public void RunFunction(System.Type characterFunctionType, float float1, float float2) {
            CharacterFunctionProcessor.DicFunction[characterFunctionType].RunFunction(float1, float2);
        }

        public void RunFunction(System.Type characterFunctionType, bool bool1)
        {
            CharacterFunctionProcessor.DicFunction[characterFunctionType].RunFunction(bool1);
        }
    }
}
