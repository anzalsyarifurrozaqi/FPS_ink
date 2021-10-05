using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class SampleController : MonoBehaviour {
        public ObjectPollManager PoolManager;
        private void Start() {
            PoolManager = ObjectPollManager.Instance;
        }
        private void Update() {
            Fire();
        }

        void Fire() {
            if (Input.GetMouseButtonDown(0)) {
                GameObject obj = GetGameObject();

                if (obj != null) {
                    obj.SetActive(true);
                    obj.transform.localPosition = Vector3.zero;
                    obj.transform.localRotation = Quaternion.identity;
                } 
                else
                {
                    Debug.Log("Couldn't find a new gameObject");
                }
            }

        }

        public GameObject GetGameObject() {
            GameObject obj = PoolManager.GetGameObject();

            return obj;
        }
    }
}