using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
    Rigidbody Rigidbody;
    PlayerConfiguration PlayerConfiguration;

    public PlayerMovement(Rigidbody rigidbody, PlayerConfiguration playerConfiguration)
    {
        this.Rigidbody = rigidbody;
        this.PlayerConfiguration = playerConfiguration;
    }

    public void VelocityMovement(Vector2 inputVec)
    {
        Vector3 movement = new Vector3(inputVec.x, 0f, inputVec.y) * PlayerConfiguration.MOVESPEED;
        Rigidbody.velocity = movement;
    }

    public void VelocityIdle()
    {
        Rigidbody.velocity = Vector3.zero;
    }

}
