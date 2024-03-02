using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSubJump : StateSuperAir
{
    public StateSubJump(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE) : base(PLAYERGENERAL, STATEMACHINE)
    {
    }

    public override void Enter()
    {
        base.Enter();
        PLAYER.ANIMATIONMANAGER.SetAnimation(PlayerAnimation.Jump);
        PLAYER.MOVEMENT.VelocityJump();
        Physics.gravity = Vector3.up * -80f;
    }

    public override void Update()
    {
        base.Update();
        if(PLAYER.MOVEMENT.VELOCITYY < 0)
        {
            STATEMACHINE.Change(PLAYER.STATES.INAIRSTATE);
        }
    }
}
