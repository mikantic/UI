using UnityEngine;
using Core.Languages;

namespace UI.Languages
{
    public class LanguageReadout : MonoBehaviour
    {
        [SerializeField] private string _input;
        [SerializeField] private string _output;
        [SerializeField] private Language _language;

        private void Start()
        {
            _output = string.Join(" ", _language?.Translate(_input));
            Debug.Log($"_input {_input}  _output {_output}");
        }

        private void OnValidate()
        {
            _output = string.Join(" ", _language?.Translate(_input));
            Debug.Log($"_input {_input}  _output {_output}");
        }
    }
}