using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Anzal.Ink
{
    public class MousePainter2 : MonoBehaviour
    {
        public Camera cam;
        [Space]
        public bool mouseSingleClick;
        [Space]
        public Color paintColor;

        public float radius = 1;
        public float strength = 1;
        public float hardness = 1;

        private void Update()
        {
            bool click;
            click = mouseSingleClick ? Input.GetMouseButtonDown(0) : Input.GetMouseButton(0);

            if (click)
            {
                Vector3 position = Input.mousePosition;
                Ray ray = cam.ScreenPointToRay(position);

                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    Debug.DrawRay(ray.origin, hit.point - ray.origin, Color.red);
                    transform.position = hit.point;
                    Paintable2 p = hit.collider.GetComponent<Paintable2>();

                    if (p != null)
                    {
                        PaintManager2.instance.paint(p, hit.point, radius, hardness, strength, paintColor);
                    }
                }
            }
        }
    }
}
