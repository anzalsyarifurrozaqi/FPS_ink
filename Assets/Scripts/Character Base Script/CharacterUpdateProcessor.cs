using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class CharacterUpdateProcessor : MonoBehaviour {
        public Dictionary<System.Type, CharacterUpdate> DicUpdaters = new Dictionary<System.Type, CharacterUpdate>();
        public CharacterUpdateList UpdateListType;

        public CharacterControl control {
            get {
                if (_control == null) {
                    _control = this.gameObject.GetComponentInParent<CharacterControl>();
                }
                return _control;
            }
        }

        private CharacterControl _control = null;

        public void InitUpdaters() {
            if (UpdateListType != null) {
                Debug.Log(UpdateListType.GetList());
                foreach (System.Type t in UpdateListType.GetList()) {
                    AddUpdater(t);
                }
            }
            else {
                Debug.Log($"Loading Default Character Updates : {this.transform.root.gameObject.name}");
                SetDefaultUpdates();
            }

            if (control.CharacterSetup.CharacterType == CharacterType.PLAYER) {
                AddUpdater(typeof(ManualInput));
                AddUpdater(typeof(CharacterAiming));
            }
        }

        void SetDefaultUpdates() {
            AddUpdater(typeof(CameraCharacter));
            AddUpdater(typeof(CameraAim));
        }

        void AddUpdater(System.Type UpdaterType) {
            if (UpdaterType.IsSubclassOf(typeof(CharacterUpdate))) {
                _AddUpdaters(UpdaterType);
            }
        }

        void _AddUpdaters (System.Type UpdaterType) {
            GameObject obj = new GameObject();
            obj.name = UpdaterType.ToString().Replace("Ink_Project.", "");
            obj.name = obj.name;
            obj.transform.parent = this.transform;
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localRotation = Quaternion.identity;
            CharacterUpdate u = obj.AddComponent(UpdaterType) as CharacterUpdate;
            u.control = this.gameObject.transform.root.GetComponent<CharacterControl>();
            DicUpdaters.Add(UpdaterType, u);

            u.InitComponent();
        }

        public void RunCharacterUpdate() {
            CharacterUpdate(typeof(ManualInput));
            CharacterUpdate(typeof(CharacterAiming));            
        }

        public void RunCharacterFixedUpdate() {
            CharacterFixedUpdate(typeof(CameraAim));
        }

        public void RunCharacterLateUpdate() {            
            CharacterLateUpdate(typeof(CameraCharacter));
        }

        void CharacterUpdate(System.Type UpdaterType) {
            if (control.CharacterUpdateProcessor.DicUpdaters.ContainsKey(UpdaterType)) {
                control.CharacterUpdateProcessor.DicUpdaters[UpdaterType].OnUpdate();
            }
        }

        void CharacterFixedUpdate(System.Type UpdaterType) {
            if (control.CharacterUpdateProcessor.DicUpdaters.ContainsKey(UpdaterType)){
                control.CharacterUpdateProcessor.DicUpdaters[UpdaterType].OnFixedUpdate();
            }
        }

        void CharacterLateUpdate(System.Type UpdaterType) {
            if (control.CharacterUpdateProcessor.DicUpdaters.ContainsKey(UpdaterType)) {
                control.CharacterUpdateProcessor.DicUpdaters[UpdaterType].OnLateUpdate();
            }            
        }
    }
}