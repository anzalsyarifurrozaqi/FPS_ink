using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class HashInitializer : MonoBehaviour {
        public List<HashClassKey> ListKeys = new List<HashClassKey>();

        public void InitAllHashKeyd() {
            foreach (HashClassKey k in ListKeys) {
                k.ShortNameHash = Animator.StringToHash(k.name);
            }
        }
    }
}