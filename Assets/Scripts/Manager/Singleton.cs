using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour {
        public static bool verbose = false;
        public static bool keepAlive = true;

        private static T _instance = null;
        public static T Instance {
            get {
                if (_instance == null) {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent<T>();
                    obj.name = typeof(T).ToString().Replace("Ink_Project.", "");
                }
                return _instance;
            }
        }

        public virtual void Awake() {
            if (_instance != null) {
                if (verbose)
                    Debug.Log("SingleAccessPoint, Destroy duplicate instance " + name + " of " + _instance.name);
                Destroy(gameObject);
                return;
            }

            _instance = GetComponent<T>();

            if (keepAlive) {
                DontDestroyOnLoad(gameObject);
            }

            if (_instance == null) {
                if (verbose)
                    Debug.LogError("SingleAccessPoint<" + typeof(T).Name + "> Instance null in Awake");
                return;
            }

            if (verbose)
                Debug.Log("SingleAccessPoint instance found " + _instance.GetType().Name);
        }
    }
}