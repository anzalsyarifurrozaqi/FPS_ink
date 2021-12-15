using UnityEngine;

namespace Ink_Project {
    public class HashManager : Singleton<HashManager> {
        HashInitializer HashInitializer = null;

        public void SetupHashInitializer() {
            if (HashInitializer == null) {
                HashInitializer = Instantiate(
                    Resources.Load("HashInitializer",
                    typeof(HashInitializer)))
                    as HashInitializer;

                HashInitializer.name = typeof(HashInitializer).ToString();
                HashInitializer.transform.position = Vector3.zero;
                HashInitializer.transform.rotation = Quaternion.identity;

                HashInitializer.InitAllHashKeyd();
            }
        }

        public int[] ArrMainParams = new int[HashTool.GetLength(typeof(MainParameterType))];

        private void Awake() {
            HashTool.AddNameHashToArray(typeof(MainParameterType), ArrMainParams);
        }
    }
}