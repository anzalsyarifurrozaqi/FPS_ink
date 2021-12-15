using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public class CharacterFunctionList : MonoBehaviour
    {
        public List<System.Type> FunctionTypes = new List<System.Type>();
        public virtual List<System.Type> GetList()
        {
            throw new System.NotImplementedException();
        }    
    }
}