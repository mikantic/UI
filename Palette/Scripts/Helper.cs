using UnityEngine;
using System;

// could potentially use a flavor enum as <T>?
// also look into making these serializeable to use in like a color dropdown or something?

// maybe make these scriptable objects? or look into ways to set the color through inspector?

namespace UI.Palettes
{
        // public static UnityEngine.Color GetColor(Color color, Shade shade)
        // {
        //     Palette palette = Resources.Load<Palette>($"Palette/{color}");
        //     if (palette != null) return palette.GetColor(shade);
        //     return UnityEngine.Color.white;
        // }
        
        // private static ColorPaletteData _data;
        // private const string DefaultPath = "ColorPaletteData"; // under Resources/

        // private static ColorPaletteData Data
        // {
        //     get
        //     {
        //         if (_data == null)
        //             _data = Resources.Load<ColorPaletteData>(DefaultPath);

        //         if (_data == null)
        //             Debug.LogError($"ColorPaletteData not found in Resources/{DefaultPath}");

        //         return _data;
        //     }
        // }

        // public static Color Get(ColorID id, Shade shade)
        // {
        //     return Data != null ? Data.Get(id, shade) : Color.magenta;
        // }
}
    
    /// <summary>
    /// additiontal interface if enforcing a palette flavor
    /// </summary>
    /// <typeparam name="F"></typeparam>
    //public interface IPalette<F> : IPalette where F : Core.Flavors.IFlavor { }

    // /// <summary>
    // /// savory palette
    // /// </summary>
    // [Serializable]
    // public class Savory : IPalette<Core.Flavors.Savory>
    // {
    //     public Color Shine { get; } = new Color32(230, 103, 124, 255);
    //     public Color Light { get; } = new Color32(191, 76, 105, 255);
    //     public Color Medium { get; } = new Color32(153, 54, 87, 255);
    //     public Color Dark { get; } = new Color32(115, 34, 68, 255);
    //     public Color Shadow { get; } = new Color32(77, 19, 48, 255);
    // }

    // /// <summary>
    // /// spicy palette
    // /// </summary>
    // [Serializable]
    // public class Spicy : IPalette<Core.Flavors.Spicy>
    // {
    //     public Color Shine { get; } = new Color32(230, 135, 103, 255);
    //     public Color Light { get; } = new Color32(191, 95, 76, 255);
    //     public Color Medium { get; } = new Color32(153, 62, 54, 255);
    //     public Color Dark { get; } = new Color32(115, 34, 34, 255);
    //     public Color Shadow { get; } = new Color32(77, 19, 24, 255);
    // }

    // /// <summary>
    // /// salty palette
    // /// </summary>
    // [Serializable]
    // public class Salty : IPalette<Core.Flavors.Salty>
    // {
    //     public Color Shine { get; } = new Color32(217, 157, 96, 255);
    //     public Color Light { get; } = new Color32(179, 116, 72, 255);
    //     public Color Medium { get; } = new Color32(140, 77, 49, 255);
    //     public Color Dark { get; } = new Color32(102, 48, 30, 255);
    //     public Color Shadow { get; } = new Color32(64, 24, 16, 255);
    // }

    // /// <summary>
    // /// sweet palette
    // /// </summary>
    // [Serializable]
    // public class Sweet : IPalette<Core.Flavors.Sweet>
    // {
    //     public Color Shine { get; } = new Color32(230, 209, 103, 255);
    //     public Color Light { get; } = new Color32(191, 162, 77, 255);
    //     public Color Medium { get; } = new Color32(153, 120, 54, 255);
    //     public Color Dark { get; } = new Color32(115, 81, 34, 255);
    //     public Color Shadow { get; } = new Color32(77, 48, 19, 255);
    // }

    // /// <summary>
    // /// bitter palette
    // /// </summary>
    // [Serializable]
    // public class Bitter : IPalette<Core.Flavors.Bitter>
    // {
    //     public Color Shine { get; } = new Color32(209, 230, 103, 255);
    //     public Color Light { get; } = new Color32(162, 191, 77, 255);
    //     public Color Medium { get; } = new Color32(120, 153, 54, 255);
    //     public Color Dark { get; } = new Color32(81, 115, 34, 255);
    //     public Color Shadow { get; } = new Color32(48, 77, 19, 255);
    // }

    // /// <summary>
    // /// minty palette
    // /// </summary>
    // [Serializable]
    // public class Minty : IPalette<Core.Flavors.Minty>
    // {
    //     public Color Shine { get; } = new Color32(115, 230, 114, 255);
    //     public Color Light { get; } = new Color32(86, 191, 121, 255);
    //     public Color Medium { get; } = new Color32(61, 153, 99, 255);
    //     public Color Dark { get; } = new Color32(40, 115, 77, 255);
    //     public Color Shadow { get; } = new Color32(23, 77, 55, 255);
    // }

    // /// <summary>
    // /// sour palette
    // /// </summary>
    // [Serializable]
    // public class Sour : IPalette<Core.Flavors.Sour>
    // {
    //     public Color Shine { get; } = new Color32(126, 195, 230, 255);
    //     public Color Light { get; } = new Color32(95, 151, 191, 255);
    //     public Color Medium { get; } = new Color32(69, 111, 153, 255);
    //     public Color Dark { get; } = new Color32(48, 75, 115, 255);
    //     public Color Shadow { get; } = new Color32(27, 44, 77, 255);
    // }

    // /// <summary>
    // /// rotten palette
    // /// </summary>
    // [Serializable]
    // public class Rotten : IPalette<Core.Flavors.Rotten>
    // {
    //     public Color Shine { get; } = new Color32(22, 13, 26, 255);
    //     public Color Light { get; } = new Color32(22, 13, 26, 255);
    //     public Color Medium { get; } = new Color32(22, 13, 26, 255);
    //     public Color Dark { get; } = new Color32(22, 13, 26, 255);
    //     public Color Shadow { get; } = new Color32(22, 13, 26, 255);
    // }

    // /// <summary>
    // /// basic palette
    // /// </summary>
    // [Serializable]
    // public class Basic : IPalette<Core.Flavors.Basic>
    // {
    //     public Color Shine { get; } = new Color32(195, 224, 230, 255);
    //     public Color Light { get; } = new Color32(163, 193, 204, 255);
    //     public Color Medium { get; } = new Color32(134, 163, 179, 255);
    //     public Color Dark { get; } = new Color32(106, 133, 153, 255);
    //     public Color Shadow { get; } = new Color32(83, 105, 128, 255);
    // }

    // /// <summary>
    // /// terrain palette
    // /// </summary>
    // [Serializable]
    // public class Terrain : IPalette
    // {
    //     public Color Shine { get; } = new Color32(124, 115, 153, 255);
    //     public Color Light { get; } = new Color32(102, 89, 128, 255);
    //     public Color Medium { get; } = new Color32(81, 66, 102, 255);
    //     public Color Dark { get; } = new Color32(62, 46, 77, 255);
    //     public UnityEngine.Color Shadow { get; } = new Color32(41, 28, 51, 255);
    // }
