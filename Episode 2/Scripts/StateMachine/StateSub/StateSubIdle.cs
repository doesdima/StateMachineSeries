using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSubIdle : StateSuperGround
{
    public StateSubIdle(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE) : base(PLAYERGENERAL, STATEMACHINE)
    {
        
    }

    public override void Enter()
    {
        base.Enter();
        PLAYER.MOVEMENT.VelocityIdle();
    }

    public override void Update()
    {
        base.Update();
        if(PLAYER.INPUTPROCESSOR.INPUTVECTOR.magnitude > 0)
        {
            STATEMACHINE.Change(PLAYER.STATES.MOVESTATE);
        }
    }
}
