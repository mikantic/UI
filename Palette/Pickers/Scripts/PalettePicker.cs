using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Palettes
{
    public abstract class PalettePicker<T> : MonoBehaviour
    {
        [SerializeField] protected Palette _palette;
        protected T _target;

        private void Reset()
        {
            if (_target == null) _target = GetComponent<T>();
        }

        protected abstract void ApplyPalette();

        private void OnValidate()
        {
            if (_target != null && _palette != null) ApplyPalette();
        }
    }
}