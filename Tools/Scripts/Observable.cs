using UnityEngine;

namespace UI.Tools
{
    /// <summary>
    /// class for components that want to display and edit backend data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="I"></typeparam>
    public abstract class Observable<T, I> : Observer<T>
    where I : IEdit<T>
    {
        [SerializeField] private I _input;

        public override void Link(Core.Tools.Observable<T> observable)
        {
            _input.Link(observable.SetValue);
            base.Link(observable);
        }

        public override void Unlink(Core.Tools.Observable<T> observable)
        {
            _input.Unlink(observable.SetValue);
            base.Unlink(observable);
        }
    }
}