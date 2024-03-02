using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager
{
    protected StateMachine STATEMACHINE;
    protected PlayerGeneral PLAYER;

    public StateManager(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE)
    {
        this.STATEMACHINE = STATEMACHINE;
        this.PLAYER = PLAYERGENERAL;
    }

    public virtual void Enter()
    {

    }

    public virtual void Exit()
    {

    }

    public virtual void Update()
    {

    }

    public virtual void FixedUpdate()
    {

    }

    public virtual void LateUpdate()
    {
        
    }
}
