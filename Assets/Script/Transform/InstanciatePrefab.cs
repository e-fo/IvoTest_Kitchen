using UnityEngine;

namespace IvoKitchen.TransformComp
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.ROOT + CMRoute.TRANSFORM + "InstanciatePrefab")]
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