using System.Collections;
using Core.Tools;
using UI.Tools;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Bar
{
    public class Bar : Observer<Clamp<float>, float>
    {
        /// <summary>
        /// image always displaying true value
        /// </summary>
        [SerializeField] private Image _value;

        /// <summary>
        /// image that displays over increasd heath range, might have to be removed or handled differently
        /// </summary>
        [SerializeField] private Image _increase;

        /// <summary>
        /// image that displays lost health from damage over time 
        /// </summary>
        [SerializeField] private Image _decrease;

        /// <summary>
        /// how fast the bars finish animating
        /// </summary>
        [SerializeField] private float _animationTime;

        /// <summary>
        /// current process lerping bars
        /// </summary>
        private Coroutine _coroutine;

        /// <summary>
        /// syncs image fill amounts with value
        /// </summary>
        /// <param name="clamp"></param>
        protected override void UpdateFrontEnd(float value)
        {
            if (_coroutine != null) StopCoroutine(_coroutine);
            _coroutine = StartCoroutine(UpdateBars(value));
        }

        /// <summary>
        /// process to lerp bar values to goal value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected virtual IEnumerator UpdateBars(float value)
        {
            float amount = _value.fillAmount;
            float difference = value - amount;

            float start = Time.time;
            float end = start + _animationTime;
            float delta = end - start;

            if (difference >= 0)
            {
                _increase.fillAmount = value;
                while (Time.time < end)
                {
                    _value.fillAmount = amount + difference * (Time.time - start) / delta;
                    yield return new WaitForEndOfFrame();
                }
            }
            else
            {
                _increase.fillAmount = _value.fillAmount = value;
                while (Time.time < end)
                {
                    _decrease.fillAmount = amount + difference * (Time.time - start) / delta;
                    yield return new WaitForEndOfFrame();
                }
            }
            _increase.fillAmount = _value.fillAmount = _decrease.fillAmount = value;
        }
    }   
}