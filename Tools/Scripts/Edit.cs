using System;
using Core.Flavor;
using UnityEngine;

namespace UI.Tools
{
    /// <summary>
    /// implemented by custom componenets that can link an action with some front end event, typucally the observalue.SetValue(T)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEdit<T>
    {
        public void Link(Action<T> action);
        public void Unlink(Action<T> action);
    }
}