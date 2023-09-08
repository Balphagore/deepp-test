using System;
using UnityEngine;

namespace DeeppTest.Utilities
{
    public static class EventInvoker
    {
        private const string noSubscribersWarning = "No subscribers to ";

        public static void InvokeEvent<TEventArgs>(object sender, EventHandler<TEventArgs> eventHandler, TEventArgs eventArgs, string eventName) where TEventArgs : EventArgs
        {
            try
            {
                eventHandler.GetInvocationList();
            }
            catch
            {
                Debug.LogWarning(noSubscribersWarning + eventName);
            }
            eventHandler?.Invoke(sender, eventArgs);
        }

        public static void InvokeEvent(object sender, EventHandler eventHandler, string eventName)
        {
            try
            {
                eventHandler.GetInvocationList();
            }
            catch
            {
                Debug.LogWarning(noSubscribersWarning + eventName);
            }
            eventHandler?.Invoke(sender, null);
        }

        public static TResult InvokeFunc<TResult>(Func<TResult> func, string eventName)
        {
            try
            {
                func.GetInvocationList();
            }
            catch
            {
                Debug.LogWarning(noSubscribersWarning + eventName);
                return default(TResult);
            }
            return func.Invoke();
        }

        public static TResult InvokeFunc<T, TResult>(Func<T, TResult> func, T arg, string eventName)
        {
            try
            {
                func.GetInvocationList();
            }
            catch
            {
                Debug.LogWarning(noSubscribersWarning + eventName);
                return default(TResult);
            }
            return func.Invoke(arg);
        }

        public static void InvokeAction(Action action, string eventName)
        {
            try
            {
                action.GetInvocationList();
            }
            catch
            {
                Debug.LogWarning(noSubscribersWarning + eventName);
                return;
            }
            action.Invoke();
        }

        public static void InvokeAction<T>(Action<T> action, T arg, string eventName)
        {
            try
            {
                action.GetInvocationList();
            }
            catch
            {
                Debug.LogWarning(noSubscribersWarning + eventName);
                return;
            }
            action.Invoke(arg);
        }
    }

    public class Vector2Args : EventArgs
    {
        public Vector2 Value { get; set; }

        public Vector2Args(Vector2 value)
        {
            Value = value;
        }
    }
}
