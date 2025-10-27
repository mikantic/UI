using System;
using Core.Tools;
using UnityEngine;

namespace UI.Tools
{
    /// <summary>
    /// class for components that want to display and edit backend data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="I"></typeparam>
    public abstract class Observable<O, T> : Observer<O, T> where O : Core.Tools.Observable<T>
    {
        private event Action<T> _editData;
        protected void UpdateBackend(T value) => _editData?.Invoke(value);

        public override void Link(O observable)
        {
            _editData += observable.SetValue;
            base.Link(observable);
        }

        public override void Unlink(O observable)
        {
            _editData -= observable.SetValue;
            base.Unlink(observable);
        }
    }
    public abstract class Observable<T> : Observable<Core.Tools.Observable<T>, T> { }
}