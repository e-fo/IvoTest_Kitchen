using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace IvoKitchen.TransformComp
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.ROOT + CMRoute.TRANSFORM + "SetInstanceIdOnVariable")]
    public class SetInstanceIdOnVariable : MonoBehaviour
    {
        [SerializeField] GameObject _gameObject;
        
        public void SetInstanceId(IntVariable variable)
        {
            variable.Value = _gameObject.GetInstanceID();
        }
    }
}