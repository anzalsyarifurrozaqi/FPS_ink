using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class ParticlePaint : MonoBehaviour {
        public Color PaintColor;

        public float MinRadius = 0.05f;
        public float MaxRadius = 0.2f;
        public float Strength = 1;
        public float Hardness = 1;

        [Space]
        ParticleSystem part;
        List <ParticleCollisionEvent> _particleCollisionEvent;

        void Start() {
            part = GetComponent<ParticleSystem>();
            _particleCollisionEvent = new List<ParticleCollisionEvent>();
        }

        void OnParticleCollision(GameObject other) {
            int numCollisionEvents = part.GetCollisionEvents(other, _particleCollisionEvent);

            Paintable2 p = other.GetComponent<Paintable2>();

            if (p != null) {
                Debug.Log("Paint");
                for (int i = 0; i < numCollisionEvents; i++) {
                    Vector3 pos = _particleCollisionEvent[i].intersection;
                    float radius = Random.Range(MinRadius, MaxRadius);
                    PaintManager2.Instance.paint(p, pos, radius, Hardness, Strength, PaintColor);
                }
            }
        }
    }
}