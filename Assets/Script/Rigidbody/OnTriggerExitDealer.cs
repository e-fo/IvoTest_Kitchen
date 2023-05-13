using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace IvoKitchen.RigidbodyComp
{
    using CMRoute = ComponentMenuRoute;
    [RequireComponent(typeof(Collider))]
    [AddComponentMenu(CMRoute.ROOT + CMRoute.RIGIBODY + "OnTriggerExitDealer")]
    public class OnTriggerExitDealer : MonoBehaviour
    {
        [SerializeField] ColliderEvent _onTriggerEnter;

        private void OnTriggerExit(Collider other)
        {
            _onTriggerEnter.Raise(other);
        }
    }
}