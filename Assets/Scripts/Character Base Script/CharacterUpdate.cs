using UnityEngine;

namespace Ink_Project
{
    public abstract class CharacterUpdate : MonoBehaviour
    {
        protected CharacterUpdateProcessor characterUpdateProcessor;
        public CharacterControl control;

        private void Awake()
        {
            characterUpdateProcessor = this.gameObject.GetComponentInParent<CharacterUpdateProcessor>();
        }

        public abstract void OnUpdate();
        public abstract void OnFixedUpdate();
        public abstract void OnLateUpdate();
        public virtual void InitComponent()
        {

        }
    }
}