using UnityEngine;

namespace Ink_Project {
    public class HashTool : MonoBehaviour {
        public static void AddNameHashToArray(System.Type enumType, int[] intArray) {
            int count = GetLength(enumType);

            for (int i = 0; i < count; i++) {
                string str = System.Enum.GetName(enumType, i);
                intArray[i] = Animator.StringToHash(str);
            }
        }

        public static int GetLength(System.Type enumType) {
            return System.Enum.GetValues(enumType).Length;
        }
    }
}