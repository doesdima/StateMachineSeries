using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSubMovement : StateSuperGround
{
    public StateSubMovement(PlayerGeneral PLAYER, StateMachine STATEMACHINE) : base(PLAYER, STATEMACHINE)
    {
    }

    public override void Update()
    {
        base.Update();
        if(PLAYER.INPUTPROCESSOR.INPUTVECTOR.magnitude == 0)
        {
            STATEMACHINE.Change(PLAYER.STATES.IDLESTATE);
        }
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
        PLAYER.MOVEMENT.VelocityMovement(PLAYER.INPUTPROCESSOR.INPUTVECTORNORMAL);
    }

}
