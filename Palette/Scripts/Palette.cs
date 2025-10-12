using UnityEngine;
using System;
using System.Reflection;

// could potentially use a flavor enum as <T>?
// also look into making these serializeable to use in like a color dropdown or something?

namespace UI.Palette
{
    /// <summary>
    /// enum for all palette types
    /// </summary>
    [Serializable]
    public enum Enum
    {
        Savory, Spicy, Salty, Sweet, Bitter, Minty, Sour, Rotten, Basic, Terrain
    }


    /// <summary>
    /// interface for a color with various lighting values
    /// </summary>
    public interface IPalette
    {
        public Color Shine { get; }
        public Color Light { get; }
        public Color Medium { get; }
        public Color Dark { get; }
        public Color Shadow { get; }
    }

    /// <summary>
    /// additiontal interface if enforcing a palette flavor
    /// </summary>
    /// <typeparam name="F"></typeparam>
    public interface IPalette<F> : IPalette where F : Core.Flavor.IFlavor { }

    /// <summary>
    /// savory palette
    /// </summary>
    [Serializable]
    public class Savory : IPalette<Core.Flavor.Savory>
    {
        public Color Shine { get; } = new Color32(230, 103, 124, 255);
        public Color Light { get; } = new Color32(191, 76, 105, 255);
        public Color Medium { get; } = new Color32(153, 54, 87, 255);
        public Color Dark { get; } = new Color32(115, 34, 68, 255);
        public Color Shadow { get; } = new Color32(77, 19, 48, 255);
    }

    /// <summary>
    /// spicy palette
    /// </summary>
    [Serializable]
    public class Spicy : IPalette<Core.Flavor.Spicy>
    {
        public Color Shine { get; } = new Color32(230, 135, 103, 255);
        public Color Light { get; } = new Color32(191, 95, 76, 255);
        public Color Medium { get; } = new Color32(153, 62, 54, 255);
        public Color Dark { get; } = new Color32(115, 34, 34, 255);
        public Color Shadow { get; } = new Color32(77, 19, 24, 255);
    }

    /// <summary>
    /// salty palette
    /// </summary>
    [Serializable]
    public class Salty : IPalette<Core.Flavor.Salty>
    {
        public Color Shine { get; } = new Color32(217, 157, 96, 255);
        public Color Light { get; } = new Color32(179, 116, 72, 255);
        public Color Medium { get; } = new Color32(140, 77, 49, 255);
        public Color Dark { get; } = new Color32(102, 48, 30, 255);
        public Color Shadow { get; } = new Color32(64, 24, 16, 255);
    }

    /// <summary>
    /// sweet palette
    /// </summary>
    [Serializable]
    public class Sweet : IPalette<Core.Flavor.Sweet>
    {
        public Color Shine { get; } = new Color32(230, 209, 103, 255);
        public Color Light { get; } = new Color32(191, 162, 77, 255);
        public Color Medium { get; } = new Color32(153, 120, 54, 255);
        public Color Dark { get; } = new Color32(115, 81, 34, 255);
        public Color Shadow { get; } = new Color32(77, 48, 19, 255);
    }

    /// <summary>
    /// bitter palette
    /// </summary>
    [Serializable]
    public class Bitter : IPalette<Core.Flavor.Bitter>
    {
        public Color Shine { get; } = new Color32(209, 230, 103, 255);
        public Color Light { get; } = new Color32(162, 191, 77, 255);
        public Color Medium { get; } = new Color32(120, 153, 54, 255);
        public Color Dark { get; } = new Color32(81, 115, 34, 255);
        public Color Shadow { get; } = new Color32(48, 77, 19, 255);
    }

    /// <summary>
    /// minty palette
    /// </summary>
    [Serializable]
    public class Minty : IPalette<Core.Flavor.Minty>
    {
        public Color Shine { get; } = new Color32(115, 230, 114, 255);
        public Color Light { get; } = new Color32(86, 191, 121, 255);
        public Color Medium { get; } = new Color32(61, 153, 99, 255);
        public Color Dark { get; } = new Color32(40, 115, 77, 255);
        public Color Shadow { get; } = new Color32(23, 77, 55, 255);
    }

    /// <summary>
    /// sour palette
    /// </summary>
    [Serializable]
    public class Sour : IPalette<Core.Flavor.Sour>
    {
        public Color Shine { get; } = new Color32(126, 195, 230, 255);
        public Color Light { get; } = new Color32(95, 151, 191, 255);
        public Color Medium { get; } = new Color32(69, 111, 153, 255);
        public Color Dark { get; } = new Color32(48, 75, 115, 255);
        public Color Shadow { get; } = new Color32(27, 44, 77, 255);
    }

    /// <summary>
    /// rotten palette
    /// </summary>
    [Serializable]
    public class Rotten : IPalette<Core.Flavor.Rotten>
    {
        public Color Shine { get; } = new Color32(22, 13, 26, 255);
        public Color Light { get; } = new Color32(22, 13, 26, 255);
        public Color Medium { get; } = new Color32(22, 13, 26, 255);
        public Color Dark { get; } = new Color32(22, 13, 26, 255);
        public Color Shadow { get; } = new Color32(22, 13, 26, 255);
    }

    /// <summary>
    /// basic palette
    /// </summary>
    [Serializable]
    public class Basic : IPalette<Core.Flavor.Basic>
    {
        public Color Shine { get; } = new Color32(195, 224, 230, 255);
        public Color Light { get; } = new Color32(163, 193, 204, 255);
        public Color Medium { get; } = new Color32(134, 163, 179, 255);
        public Color Dark { get; } = new Color32(106, 133, 153, 255);
        public Color Shadow { get; } = new Color32(83, 105, 128, 255);
    }

    /// <summary>
    /// terrain palette
    /// </summary>
    [Serializable]
    public class Terrain : IPalette
    {
        public Color Shine { get; } = new Color32(124, 115, 153, 255);
        public Color Light { get; } = new Color32(102, 89, 128, 255);
        public Color Medium { get; } = new Color32(81, 66, 102, 255);
        public Color Dark { get; } = new Color32(62, 46, 77, 255);
        public UnityEngine.Color Shadow { get; } = new Color32(41, 28, 51, 255);
    }
}