using Core.Tools;
using UI.Tools;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Bar
{
    public class Bar : Observer<Clamp<float>>
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
        /// syncs image fill amounts with value
        /// </summary>
        /// <param name="clamp"></param>
        protected override void UpdateFrontend(Clamp<float> clamp)
        {
            float lerp = (clamp.Value - clamp.Min) / (clamp.Max - clamp.Min);
            _value.fillAmount = lerp;
        }
    }   
}