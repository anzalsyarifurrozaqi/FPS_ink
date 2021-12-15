using UnityEngine;

namespace Ink_Project {
    public class CollisionPaint : MonoBehaviour {
        public Color paintColor;

        public float radius = 1;
        public float strength = 1;
        public float hardness = 1;

        private void OnCollisionEnter(Collision other) {
            Paintable2 p = other.collider.GetComponent<Paintable2>();
            if (p != null) {                
                Vector3 pos = other.contacts[0].point;
                PaintManager2.Instance.paint(p, pos, radius, hardness, strength, paintColor);
            }
        }
    }
}