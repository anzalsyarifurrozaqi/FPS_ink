using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public class FaceForward : CharacterFunction
    {
        private float _targetRotation;
        private Camera _cam => CameraManager.Instance.MainCamera;
        private float _rotationVelocity;
        private float _rotationSmoothTime = 0.12f;

        public override void RunFunction(Vector2 move)
        {
            Vector3 inputDirection = new Vector3(control.Move.x, 0.0f, control.Move.y).normalized;

            if (move != Vector2.zero)
            {
                _targetRotation = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg + _cam.transform.eulerAngles.y;
                float rotation = Mathf.SmoothDampAngle(control.transform.eulerAngles.y, _targetRotation, ref _rotationVelocity, _rotationSmoothTime);

                control.transform.rotation = Quaternion.Euler(0.0f, rotation, 0.0f);
            }
        }
    }
}