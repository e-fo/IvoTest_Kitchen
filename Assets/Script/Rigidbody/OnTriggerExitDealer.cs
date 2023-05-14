using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityEngine.Events;

namespace IvoKitchen.RigidbodyComp
{
    using CMRoute = ComponentMenuRoute;
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu(CMRoute.ROOT + CMRoute.RIGIBODY + "OnTriggerExitDealer")]
    public class OnTriggerExitDealer : MonoBehaviour
    {
        [SerializeField] ColliderEvent _onTriggerExit;
        [SerializeField] UnityEvent _onTrigerExitUnityEvent;
        private void OnTriggerExit(Collider other)
        {
            _onTriggerExit?.Raise(other);
            _onTrigerExitUnityEvent?.Invoke();
        }
    }
}