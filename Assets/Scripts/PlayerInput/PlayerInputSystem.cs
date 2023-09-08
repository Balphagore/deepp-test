using System;
using UnityEngine;
using UnityEngine.InputSystem;

using DeeppTest.Utilities;

namespace DeeppTest.PlayerInput
{
    public class PlayerInputSystem : MonoBehaviour, IPlayerInputSystem
    {
        public event Action<Vector2> MovementEvent;
        public event Action<Vector2> LookEvent;
        public event Action FireEvent;

        public void OnMovement(InputValue value)
        {
            EventInvoker.InvokeAction(MovementEvent, value.Get<Vector2>(), nameof(MovementEvent));
        }

        public void OnLook(InputValue value)
        {
            EventInvoker.InvokeAction(LookEvent, value.Get<Vector2>(), nameof(LookEvent));
        }

        public void OnFire(InputValue value)
        {
            EventInvoker.InvokeAction(FireEvent, nameof(FireEvent));
        }
    }
}
