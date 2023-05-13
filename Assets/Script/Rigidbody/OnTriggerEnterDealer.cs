using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace IvoKitchen.RigidbodyComp
{
    using CMRoute = ComponentMenuRoute;
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu(CMRoute.ROOT + CMRoute.RIGIBODY + "OnTriggerEnterDealer")]
    public class OnTriggerEnterDealer : MonoBehaviour
    {
        [SerializeField] ColliderEvent _onTriggerEnter;

        private void OnTriggerEnter(Collider other)
        {
            _onTriggerEnter.Raise(other);
        }
    }
}