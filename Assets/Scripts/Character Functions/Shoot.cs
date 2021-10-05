using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class Shoot : CharacterFunction {
        private GameObject _parentProjectile => control.DATASET.WEAPON_DATA.ParentProjectile;
        public override void RunFunction() {
            GameObject obj = GetGameObject();

            if (obj != null) {
                obj.SetActive(true);

                obj.transform.localPosition = _parentProjectile.transform.position;
                obj.transform.localRotation = _parentProjectile.transform.rotation;
            }
            else {
                Debug.Log("Couldn't find a new GameObject");
            }
        }

        private GameObject GetGameObject() {
            var obj = ObjectPollManager.Instance.GetGameObject();

            return obj;
        }
    }
}