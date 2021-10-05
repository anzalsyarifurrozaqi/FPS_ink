using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public class Setting : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("Loading Input Character");
            InputManager.Instance.LoadPlayerInput();
        }
    }
}
