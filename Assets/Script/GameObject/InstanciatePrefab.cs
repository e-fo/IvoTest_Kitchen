using UnityEngine;

namespace IvoKitchen.TransformComp
{
    public class InstanciatePrefab : MonoBehaviour
    {
        [SerializeField] Transform _parent;
        [SerializeField] Vector3 _intialLocalPos;

        public void Instanciate(GameObject prefab)
        {
            var go = GameObject.Instantiate(prefab, _parent);
            go.transform.localPosition = _intialLocalPos;
        }
    }
}