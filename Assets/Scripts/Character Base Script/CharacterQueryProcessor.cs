using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public class CharacterQueryProcessor : MonoBehaviour
    {
        public Dictionary<System.Type, CharacterQuery> DicQueries = new Dictionary<System.Type, CharacterQuery>();
        public CharacterQueryList QueryListType;

        private void Start()
        {
            
        }

        void SetDefaultQuaries()
        {

        }

        void AddQuery(System.Type type)
        {

        }
    }
}