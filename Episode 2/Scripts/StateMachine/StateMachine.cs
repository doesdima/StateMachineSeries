using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public StateManager state {get; private set;}

    public void Init(StateManager state)
    {
        this.state = state;
        this.state.Enter();
    }

    public void Change(StateManager state)
    {
        this.state.Exit();
        Init(state);
    }
}
