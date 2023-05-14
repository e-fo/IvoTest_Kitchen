using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityEngine.Events;

namespace IvoKitchen.RigidbodyComp
{
    using CMRoute = ComponentMenuRoute;
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu(CMRoute.ROOT + CMRoute.RIGIBODY + "OnTriggerEnterDealer")]
    public class OnTriggerEnterDealer : MonoBehaviour
    {
        [SerializeField] ColliderEvent _onTriggerEnter;
        [SerializeField] UnityEvent _onTriggerEnterUnityEvent;

        private void OnTriggerEnter(Collider other)
        {
            _onTriggerEnter?.Raise(other);
            _onTriggerEnterUnityEvent?.Invoke();
        }
    }
}