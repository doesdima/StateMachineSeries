using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StateSubInteract : StateSuperAction
{

    float enterTime;

    public StateSubInteract(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE) : base(PLAYERGENERAL, STATEMACHINE)
    {
    }

    public override void Enter()
    {
        base.Enter();
        PLAYER.MOVEMENT.VelocityIdle();
        Collider closestCollider = PLAYER.COLLISION.INTERACT.OrderBy(c => Vector3.Distance(PLAYER.transform.position, c.transform.position)).FirstOrDefault();
        closestCollider.GetComponent<IInteractable>().Interact();
        enterTime = Time.time;
    }

    public override void Update()
    {
        base.Update();
        if(Time.time > enterTime + 0.4f)
        {
            STATEMACHINE.Change(PLAYER.STATES.IDLESTATE);
        }
    }

}