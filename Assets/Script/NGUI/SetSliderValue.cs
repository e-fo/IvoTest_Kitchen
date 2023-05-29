using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

namespace IvoKitchen.Timer
{
    using CMRoute = ComponentMenuRoute;
    [RequireComponent(typeof(Slider))]
    [AddComponentMenu(CMRoute.ROOT + CMRoute.NGUI + "SetSliderValue")]
    public class SetSliderValue : MonoBehaviour
    {
        [SerializeField] FloatVariable _value;
        [SerializeField] FloatConstant _max;
        private Slider _slider;

        private void OnEnable()
        {
            _slider = GetComponent<Slider>();
            _value.Changed.Register(SetValue);
        }

        private void OnDisable()
        {
            _value.Changed.Unregister(SetValue);
        }

        public void SetValue(float val)
        {
            _slider.value = val/_max.Value;
        }
    }
}