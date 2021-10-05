using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class CameraManager : Singleton<CameraManager> {
        public Camera MainCamera;
        public CameraControl CameraControl;
        public bool BlockRotationPlayer;

        public void RotateToCamera() {

        }
    }
}