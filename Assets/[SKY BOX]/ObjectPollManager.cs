using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ink_Project {
    public class ObjectPollManager : Singleton<ObjectPollManager> {

        // Optimized
        public PooledObject GameObjectPrefab;

        private List<PooledObject> GameObjectList = new List<PooledObject>();
        private const int INITIAL_POOL_SIZE = 10;
        private const int MAX_POOL_SIZE = 20;

        private PooledObject firstAvailable;

        private void Awake() {
            var obj = Resources.Load("Sample-ObjPool") as GameObject;
            GameObjectPrefab = obj.gameObject.GetComponent<PooledObject>();

            if (GameObjectPrefab == null) {
                Debug.LogError("Need a reference to the bullet prefab");
            }

            for (int i = 0; i < INITIAL_POOL_SIZE; i++) {
                GenerateBullet();
            }

            firstAvailable = GameObjectList[0];

            for (int i = 0; i < GameObjectList.Count - 1; i++) {
                GameObjectList[i].Next = GameObjectList[i + 1];
            }

            GameObjectList[GameObjectList.Count - 1].Next = null;
        }

        private void GenerateBullet() {
            PooledObject obj = Instantiate(GameObjectPrefab, transform);

            obj.gameObject.SetActive(false);

            GameObjectList.Add(obj);

            obj.PoolManager = this;
        }

        public void ConfigureDeactivateGameobject(PooledObject deactivatdObj) {
            deactivatdObj.Next = firstAvailable;

            firstAvailable = deactivatdObj;
        }

        public GameObject GetGameObject() {
            if (firstAvailable == null) {
                if (GameObjectList.Count < MAX_POOL_SIZE) {
                    GenerateBullet();

                    PooledObject LastGameObject = GameObjectList[GameObjectList.Count - 1];
                    ConfigureDeactivateGameobject(LastGameObject);
                }
                else {
                    return null;
                }
            }

            PooledObject obj = firstAvailable;
            firstAvailable = obj.Next;
            return obj.gameObject;
        }        

        // Slow
        //public GameObject gameObject;

        //private List<GameObject> gameObjectList = new List<GameObject>();

        //private const int INITIAL_POOL_SIZE = 10;
        //private const int MAX_POOL_SIZE = 20;

        //private void Start() {
        //    if (gameObject == null) {
        //        Debug.LogError("Need a reference to the gameObject prefab");
        //    }

        //    for (int i = 0; i < INITIAL_POOL_SIZE; i++) {
        //        GenerateGameObject();
        //    }
        //}

        //public void GenerateGameObject() {
        //    GameObject obj = Instantiate(gameObject, transform);
        //    obj.SetActive(false);
        //    gameObjectList.Add(obj);
        //}

        //public GameObject GetGameObject() {
        //    for (int i = 0; i < gameObjectList.Count; i++) {
        //        GameObject obj = gameObjectList[i];

        //        if (!obj.activeInHierarchy) {
        //            return obj;
        //        }
        //    }

        //    if (gameObjectList.Count < MAX_POOL_SIZE) {
        //        GenerateGameObject();

        //        GameObject obj = gameObjectList[gameObjectList.Count - 1];

        //        return obj;
        //    }

        //    return null;
        //}        
    }
}