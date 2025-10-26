using UnityEngine;
using UnityEngine.UI;

namespace UI.Palettes
{
    [RequireComponent(typeof(Renderer))]
    public class RendererPicker : PalettePicker<Renderer>
    {
        protected override void ApplyPalette()
        {
            _target.material.SetColor("_Shine", _palette.GetColor(Shade.Shine));
            _target.material.SetColor("_Light", _palette.GetColor(Shade.Light));
            _target.material.SetColor("_Medium", _palette.GetColor(Shade.Medium));
            _target.material.SetColor("_Dark", _palette.GetColor(Shade.Dark));
            _target.material.SetColor("_Shadow", _palette.GetColor(Shade.Shadow));
        }
    }
}