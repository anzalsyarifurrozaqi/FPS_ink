using UnityEngine;

namespace Ink_Project {
    public class Dataset : MonoBehaviour {
        public AbilityData ABILITY_DATA;
        public RigData RIG_DATA;
        public WeaponData WEAPON_DATA;
        public CameraCharacterData CAMERA_CHARACTER_DATA;
        public AimData AIM_DATA;

        [SerializeField] DatasetBase[] arrSets;

        public void InitDataset() {
            
        }

        public float GetFloat(CharacterDataType dataType, int dataIndex) {
            return 1;
        }

        public void SetFloat (CharacterDataType dataType, int dataIndex, float value) {
            
        }
        
    }
}