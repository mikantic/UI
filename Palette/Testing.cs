using Core.Tools;
using UI.Bar;
using UI.Palettes;
using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
    [SerializeField] private Bar _bar;
    private Clamp<float> _value { get; } = new Clamp<float>(0f, 1f, 0.5f);
    private void Start()
    {
        _bar.Link(_value);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            _value.SetValue(0.5f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _value.SetValue(0.75f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _value.SetValue(0.25f);
        }
    }
}