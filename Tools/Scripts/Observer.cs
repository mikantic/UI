using UnityEngine;

namespace UI.Tools
{
    /// <summary>
    /// class for components that want to display backend data without editing
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Observer<O, T> : MonoBehaviour where O : Core.Tools.Observable<T>
    {
        protected abstract void UpdateFrontEnd(T value);
        public virtual void Link(O observable)
        {
            observable.OnValueChanged += UpdateFrontEnd;
            UpdateFrontEnd(observable.Value);
        }

        public virtual void Unlink(O observable)
        {
            observable.OnValueChanged -= UpdateFrontEnd;
        }
    }

    public abstract class Observer<T> : Observer<Core.Tools.Observable<T>, T> { }
}