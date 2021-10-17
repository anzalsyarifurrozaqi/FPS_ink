using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class PooledObject : MonoBehaviour {
        public Color paintColor;

        public float radius = 1;
        public float strength = 1;
        public float hardness = 1;

        // Optimized
        private float _speed = 50f;
        private float _distanceDeactiveObj = 30f;
        private Rigidbody RB {
            get {
                return this.gameObject.GetComponent<Rigidbody>();
            }
        }

        [System.NonSerialized] public PooledObject Next;
        [System.NonSerialized] public ObjectPollManager PoolManager;
        private void Update() {
            RB.velocity = transform.forward * _speed;
            if (Vector3.SqrMagnitude(transform.position) > _distanceDeactiveObj * _distanceDeactiveObj) {
                PoolManager.ConfigureDeactivateGameobject(this);
                gameObject.SetActive(false);
            }
        }

        private void OnCollisionEnter(Collision other)
        {
            Paintable2 p = other.collider.GetComponent<Paintable2>();
            if (p != null)
            {
                Debug.Log("Paint");
                Vector3 pos = other.contacts[0].point;
                PaintManager2.Instance.paint(p, pos, radius, hardness, strength, paintColor);
            }

            RB.velocity = Vector3.zero;
            PoolManager.ConfigureDeactivateGameobject(this);
            gameObject.SetActive(false);
        }
    }
}