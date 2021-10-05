using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class CameraCharacter : CharacterUpdate {
        private CameraControl _cameraControl => CameraManager.Instance.CameraControl;
        private const float _threshold = 0.01f;
        private float _topClamp = 70.0f;
        private float _bottomClamp = -30.0f;
        public override void InitComponent() {
            
        }
        public override void OnFixedUpdate() {
            throw new System.NotImplementedException();
        }

        public override void OnLateUpdate() {
            if (control.Look.sqrMagnitude >= _threshold && !_cameraControl.LockCameraPosition)
            {
                _cameraControl.CinemachineTargetYaw += control.Look.x * Time.deltaTime;
                _cameraControl.CinemachineTargetPitch += control.Look.y * Time.deltaTime;
            }

            _cameraControl.CinemachineTargetYaw = ClampAngle(
                _cameraControl.CinemachineTargetYaw,
                float.MinValue,
                float.MaxValue);

            _cameraControl.CinemachineTargetPitch = ClampAngle(
                _cameraControl.CinemachineTargetPitch,
                _bottomClamp,
                _topClamp);            

            control.DATASET.CAMERA_CHARACTER_DATA.CameraRoot.transform.rotation = Quaternion.Euler(
                _cameraControl.CinemachineTargetPitch + _cameraControl.CameraAngleOverride,
                _cameraControl.CinemachineTargetYaw,
                0.0f);
        }

        public override void OnUpdate() {
            throw new System.NotImplementedException();
        }

        private static float ClampAngle (float lfAngle, float lfMin, float lfMax) {
            if (lfAngle < -360f) lfAngle += 360f;
            if (lfAngle > 360f) lfAngle -= 360f;
            return Mathf.Clamp(lfAngle, lfMin, lfMax);
        }
    }
}