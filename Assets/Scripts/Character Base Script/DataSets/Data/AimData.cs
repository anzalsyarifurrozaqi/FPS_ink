using UnityEngine;

namespace Ink_Project {
    [System.Serializable]
    public class AimData {
        public LayerMask AimLayerMask = new LayerMask();
        public GameObject DebugTransform;
    }
}