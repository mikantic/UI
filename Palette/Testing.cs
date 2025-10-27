using UI.Palettes;
using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
    [SerializeField] private Graphic _graphic;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _graphic.color = Savory.Medium;   
        }
    }
}