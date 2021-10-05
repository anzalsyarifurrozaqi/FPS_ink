using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public class CharacterUpdateList : MonoBehaviour
    {
        public List<System.Type> UpdateType = new List<System.Type>();
        public virtual List<System.Type> GetList()
        {
            throw new System.NotImplementedException();
        }
    }
}