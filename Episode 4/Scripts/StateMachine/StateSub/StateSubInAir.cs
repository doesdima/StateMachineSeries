using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSubInAir : StateSuperAir
{
    public StateSubInAir(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE) : base(PLAYERGENERAL, STATEMACHINE)
    {
    }

    public override void Enter()
    {
        base.Enter();
        PLAYER.ANIMATIONMANAGER.SetAnimation(PlayerAnimation.InAir);
    }

    public override void Update()
    {
        base.Update();
        if(PLAYER.COLLISION.GROUND)
        {
            if(PLAYER.INPUTPROCESSOR.INPUTVECTORNORMAL.magnitude == 0)
            {
                STATEMACHINE.Change(PLAYER.STATES.IDLESTATE);
            }
            else
            {
                STATEMACHINE.Change(PLAYER.STATES.MOVESTATE);
            }
        }
    }

    public override void Exit()
    {
        base.Exit();
        Physics.gravity = Vector3.up * -9.81f;
    }
}
