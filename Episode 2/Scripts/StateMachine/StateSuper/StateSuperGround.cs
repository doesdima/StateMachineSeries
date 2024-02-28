using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSuperGround : StateManager
{
    public StateSuperGround(PlayerGeneral PLAYER, StateMachine STATEMACHINE) : base(PLAYER, STATEMACHINE)
    {

    }

    public override void Update()
    {
        base.Update();
        if(!PLAYER.COLLISION.GROUND)
        {
            STATEMACHINE.Change(PLAYER.STATES.INAIRSTATE);
        }

        if(PLAYER.COLLISION.GROUND && PLAYER.INPUTPROCESSOR.INPUTJUMP > Time.time)
        {
            PLAYER.INPUTPROCESSOR.ProcessInputJump(0);
            STATEMACHINE.Change(PLAYER.STATES.JUMPSTATE);
        }
    }
}
