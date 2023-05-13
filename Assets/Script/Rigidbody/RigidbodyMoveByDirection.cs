using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace IvoKitchen.RigidbodyComp
{
    using CMRoute = ComponentMenuRoute;
    [RequireComponent(typeof(Rigidbody))]
    [AddComponentMenu(CMRoute.ROOT + CMRoute.RIGIBODY + "RigidbodyMoveByDirection")]
    public class RigidbodyMoveByDirection : MonoBehaviour
    {
        [SerializeField] Vector2Variable _moveValue;
        [SerializeField] FloatConstant _velocity;
        Rigidbody _rb;
        Vector3 _dir;


        private void OnEnable()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void Update() 
        {
            _dir = new Vector3(_moveValue.Value.x, 0, _moveValue.Value.y).normalized;
        }

        private void FixedUpdate()
        {
            _rb.velocity = _dir * _velocity.Value;
        }
    }
}