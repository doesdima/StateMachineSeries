using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateCollection 
{
    public StateSubIdle IDLESTATE {get; private set;}
    public StateSubMovement MOVESTATE {get; private set;}


    public StateCollection(PlayerGeneral playerGeneral, StateMachine stateMachine)
    {
        IDLESTATE = new StateSubIdle(playerGeneral, stateMachine);
        MOVESTATE = new StateSubMovement(playerGeneral, stateMachine);
    }
}
