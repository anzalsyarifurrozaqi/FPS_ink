using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public class CharacterQueryList : MonoBehaviour
    {
        public List<System.Type> QueryType = new List<System.Type>();
        public virtual List<System.Type> GetList()
        {
            throw new System.NotImplementedException();
        }
    }
}