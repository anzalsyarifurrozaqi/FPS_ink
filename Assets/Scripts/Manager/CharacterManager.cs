using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project
{
    public class CharacterManager : Singleton<CharacterManager> {
        public List<CharacterControl> Characters = new List<CharacterControl>();

        [SerializeField]
        CharacterControl[] ArrCharacters = null;

        private void Update()
        {
            InitCharacterArray();

            for (int i = 0; i < ArrCharacters.Length; i++)
            {
                ArrCharacters[i].CharacterUpdate();
            }
        }

        private void FixedUpdate()
        {
            InitCharacterArray();

            for (int i = 0; i < ArrCharacters.Length; i++)
            {
                ArrCharacters[i].CharacterFixedUpdate();
            }
        }

        private void LateUpdate()
        {
            InitCharacterArray();

            for (int i = 0; i < ArrCharacters.Length; i++)
            {
                ArrCharacters[i].CharacterLateUpdate();
            }
        }

        void InitCharacterArray()
        {
            if (ArrCharacters == null || ArrCharacters.Length != Characters.Count)
            {
                ArrCharacters = new CharacterControl[Characters.Count];

                for (int i = 0; i < Characters.Count; i++)
                {
                    ArrCharacters[i] = Characters[i];
                }
            }
        }

        public CharacterControl GetCharacter(GameObject obj)
        {
            for (int i = 0; i < ArrCharacters.Length; i++)
            {
                if (ArrCharacters[i].gameObject == obj)
                {
                    return ArrCharacters[i];
                }
            }

            return null;
        }

        public CharacterControl GetPlayable()
        {
            for (int i = 0; i < ArrCharacters.Length; i++)
            {
                if (ArrCharacters[i].GetUpdater(typeof(MainInput)) != null)
                {
                    return ArrCharacters[i];
                }
            }

            return null;
        }

        public CharacterControl GetPlayableeCharacter()
        {
            foreach (CharacterControl control in Characters)
            {
                if (control.CharacterUpdateProcessor.DicUpdaters.ContainsKey(typeof(ManualInput)))
                {
                    return control;
                }
            }

            return null;
        }
    }
}