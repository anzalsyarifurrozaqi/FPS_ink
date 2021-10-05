using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class CameraAim : CharacterUpdate
    {
        private AimData _aimData => control.DATASET.AIM_DATA;
        public override void InitComponent() {
            
        }
        public override void OnFixedUpdate()
        {
            Vector3 mouseWorldPosition = Vector3.zero;
            Vector2 screenCenterPoint = new Vector2(Screen.width / 2f, Screen.height / 2f);
            Ray ray = Camera.main.ScreenPointToRay(screenCenterPoint);
            if (Physics.Raycast(ray, out RaycastHit hit, 999f, _aimData.AimLayerMask))
            {
                _aimData.DebugTransform.transform.position = hit.point;
                mouseWorldPosition = hit.point;
            }

            if (control.Aim)
            {
                Vector3 worldAimTarget = mouseWorldPosition;
                worldAimTarget.y = control.transform.position.y;
                Vector3 aimTarget = (worldAimTarget - control.transform.position).normalized;

                control.transform.forward = Vector3.Lerp(control.transform.forward, aimTarget, Time.deltaTime * 20f);
            }
        }

        public override void OnLateUpdate()
        {
            throw new System.NotImplementedException();
        }

        public override void OnUpdate()
        {
            throw new System.NotImplementedException();
        }
    }
}