using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace IvoKitchen.TransformComp
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.ROOT + CMRoute.TRANSFORM + "InstanciatePrefabFromEnumPair")]
    public class InstanciatePrefabFromEnumPair : MonoBehaviour
    {
        [SerializeField] Transform _parent;
        [SerializeField] Vector3 _intialLocalPos;

        [Header("Just pass SOEnumBase list to the bellow list otherwise you will get runtime error")]
        [SerializeField] BaseAtomValueList _enumList;
        [SerializeField] GameObjectValueList _prefabList;

        public void Instanciate(SOEnumBase key)
        {
            int index = _enumList.IList.IndexOf(key);

            var go = GameObject.Instantiate(_prefabList[index], _parent);
            go.transform.localPosition = _intialLocalPos;
        }
    }
}