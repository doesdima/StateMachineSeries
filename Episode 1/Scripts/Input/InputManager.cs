using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    [SerializeField] PlayerGeneral PLAYER;

    public void InputMovement(InputAction.CallbackContext context)
    {
        PLAYER.INPUTPROCESSOR.ProcessInputVector(context.ReadValue<Vector2>());
    }
}