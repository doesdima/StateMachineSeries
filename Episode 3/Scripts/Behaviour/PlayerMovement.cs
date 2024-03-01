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
        PlayerRotation();
    }

    public void VelocityMovementInAir(Vector2 inputVec)
    {
        Vector3 movement = new Vector3(inputVec.x * PlayerConfiguration.MOVESPEED, Rigidbody.velocity.y, inputVec.y * PlayerConfiguration.MOVESPEED);
        Rigidbody.velocity = movement;
        PlayerRotation();
    }

    public void VelocityIdle()
    {
        Rigidbody.velocity = Vector3.zero;
    }

    public void PlayerRotation()
    {
        Vector3 velocityWithoutY = new Vector3(Rigidbody.velocity.x, 0f, Rigidbody.velocity.z);
        if(velocityWithoutY != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(velocityWithoutY.normalized, Vector3.up);
            Quaternion newRotation = Quaternion.Euler(0f, Quaternion.Lerp(Rigidbody.rotation, targetRotation, PlayerConfiguration.TURNSPEED * Time.deltaTime).eulerAngles.y ,0f);
            Rigidbody.MoveRotation(newRotation);
        }
    }

    public void VelocityJump()
    {
        Rigidbody.velocity = Vector3.up * PlayerConfiguration.JUMPFORCE;
    }

    public float VELOCITYY => Rigidbody.velocity.y;

}
