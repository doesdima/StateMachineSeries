using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSuperAir : StateManager
{
    public StateSuperAir(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE) : base(PLAYERGENERAL, STATEMACHINE)
    {
    }

    public override void FixedUpdate()
    {
        base.FixedUpdate();
        PLAYER.MOVEMENT.VelocityMovementInAir(PLAYER.INPUTPROCESSOR.INPUTVECTORNORMAL);
    }
}
