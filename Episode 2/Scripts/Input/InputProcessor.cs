using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputProcessor
{
    
    public InputProcessor()
    {

    }

    Vector2 inputVector;
    public Vector2 INPUTVECTOR => inputVector;
    public Vector2 INPUTVECTORNORMAL => inputVector.normalized;

    float inputJump;
    public float INPUTJUMP => inputJump;

    public void ProcessInputVector(Vector2 value)
    {
        this.inputVector = value;
    }

    public void ProcessInputJump(float value)
    {
        this.inputJump = value;
    }
}
