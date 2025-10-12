using UnityEngine;

namespace UI.Tools
{
    /// <summary>
    /// class for components that want to display backend data without editing
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Observer<T> : MonoBehaviour
    {   
        protected abstract void UpdateFrontend(T value);

        public virtual void Link(Core.Tools.Observable<T> observable)
        {
            observable.OnValueChanged += UpdateFrontend;
            UpdateFrontend(observable.Value);
        }
    
        public virtual void Unlink(Core.Tools.Observable<T> observable)
        {
            observable.OnValueChanged -= UpdateFrontend;
        }
    }
}