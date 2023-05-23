using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace UnityAtoms
{
    using CMRoute = IvoKitchen.ComponentMenuRoute;
    [AddComponentMenu("Unity Atoms/InstanceId")]
    public class InstanceId : MonoBehaviour
    {
        private static Dictionary<int, GameObject> _instanceIdMap = new();
        private static bool _initialized = false;
#if UNITY_EDITOR
        private int _gameObjectInstanceId; //Just for showing in inspector debug mode.
#endif
        public static GameObject FindObject(int instanceId)
        {
            return _instanceIdMap[instanceId];
        }

        private void Start()
        {
            if (!_initialized)
            {
                SceneManager.activeSceneChanged += OnSceneChanged;
                _initialized = true;
            }
        }

        private static void OnSceneChanged(Scene arg0, Scene arg1)
        {
            _initialized = false;
            _instanceIdMap.Clear();
            SceneManager.activeSceneChanged -= OnSceneChanged;
        }

        void OnEnable()
        {
#if UNITY_EDITOR
            _gameObjectInstanceId = this.gameObject.GetInstanceID();
#endif
            if (false == _instanceIdMap.ContainsKey(gameObject.GetInstanceID()))
            {
                _instanceIdMap.Add(gameObject.GetInstanceID(), gameObject);
            }
        }

        void OnDisable()
        {
            if(_instanceIdMap.ContainsKey(gameObject.GetInstanceID()))
            {
                _instanceIdMap.Remove(gameObject.GetInstanceID());
            }
        }
    }
}