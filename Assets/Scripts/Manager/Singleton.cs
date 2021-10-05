using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance = null;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    _instance = obj.AddComponent<T>();
                    obj.name = typeof(T).ToString().Replace("Ink_Project.", "");
                }
                return _instance;
            }
        }
    }
}