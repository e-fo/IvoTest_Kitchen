using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityAtoms.BaseAtoms;

namespace IvoKitchen.Timer
{
    using CMRoute = ComponentMenuRoute;
    [AddComponentMenu(CMRoute.ROOT + CMRoute.TIMER + "Timer")]
    public class Timer : MonoBehaviour
    {
        [SerializeField] FloatVariable _remainTime;
        [SerializeField] FloatConstant _duration;
        [SerializeField] UnityEvent _onTimerElapsed;
        private WaitForEndOfFrame _wait = null;

        public void StartTimer()
        {
            _wait = new WaitForEndOfFrame();
            _remainTime.Value = 0;
            StartCoroutine(StartTimerCorout());
        }

        public IEnumerator StartTimerCorout()
        {
            float remain = _remainTime.Value;
            while(Mathf.Abs(_duration.Value - remain) > 0.01f ) 
            {
                remain += Time.deltaTime;
                _remainTime.Value = remain;
                yield return _wait;
            }
            _wait = null;
            _onTimerElapsed?.Invoke();
        }
    }
}