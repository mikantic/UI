using UnityEngine;
using UnityEngine.UI;

namespace UI.Palettes
{
    [RequireComponent(typeof(Graphic))]
    public class GraphicPicker : PalettePicker<Graphic>
    {
        [SerializeField] private Shade _shade;
        protected override void ApplyPalette()
        {
            _target.color = _palette.GetColor(_shade);
        }
    }
}