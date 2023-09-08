using System;
using UnityEngine;

namespace DeeppTest.PlayerInput
{
    public interface IPlayerInputSystem
    {
        event Action<Vector2> MovementEvent;
        event Action<Vector2> LookEvent;
        event Action FireEvent;
    }
}