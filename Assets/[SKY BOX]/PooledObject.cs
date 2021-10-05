using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class PooledObject : MonoBehaviour {
        // Optimized
        private float _speed = 50f;
        private float _distanceDeactiveObj = 30f;

        [System.NonSerialized] public PooledObject Next;
        [System.NonSerialized] public ObjectPollManager PoolManager;
        private void Update() {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            if (Vector3.SqrMagnitude(transform.position) > _distanceDeactiveObj * _distanceDeactiveObj) {
                PoolManager.ConfigureDeactivateGameobject(this);
                gameObject.SetActive(false);
            }
        }
        
        // Slow
        //private void OnEnable()
        //{
        //    Invoke("SetNonActive", 3);
        //}

        //void SetNonActive()
        //{
        //    gameObject.SetActive(false);
        //}
    }
}