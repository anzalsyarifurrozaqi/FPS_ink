using UnityEngine;

namespace Ink_Project {
    public class CameraControl : MonoBehaviour {
        
        public Camera Cam {
            get {
                if (_cam == null) {
                    _cam = GetComponent<Camera>();                
                }

                return _cam;
            }
        }
        private Camera _cam;

        public float CinemachineTargetYaw;
        public float CinemachineTargetPitch;
        public bool LockCameraPosition = false;
        public float CameraAngleOverride = 0.0f;
        public GameObject CameraFireAim;

        void InitCamera() {
            CameraManager.Instance.MainCamera = Cam;
            CameraManager.Instance.CameraControl = this;
        }

        private void Awake()
        {
            InitCamera();
        }

        public void ActiveCameraFireAim(bool Active) {
            Debug.Log("active fire aim");
            CameraFireAim.SetActive(Active);
        }
    }
}