using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerGeneral : MonoBehaviour
{

    StateMachine StateMachine;
    public StateMachine STATEMACHINE => StateMachine;


    StateCollection States;
    public StateCollection STATES => States;

    InputProcessor InputProcessor;
    public InputProcessor INPUTPROCESSOR => InputProcessor;

    PlayerMovement PlayerMovement;
    public PlayerMovement MOVEMENT => PlayerMovement;

    public PlayerCollision COLLISION => playerCollision;

    [Header("Components")]
    [SerializeField] Rigidbody Rigidbody;
    [SerializeField] PlayerConfiguration PlayerConfiguration;
    [SerializeField] PlayerCollision playerCollision;

    [Header("UI")]
    [SerializeField] TextMeshProUGUI CurrentState;


    private void Awake() 
    {
        StateMachine = new StateMachine();
        States = new StateCollection(this, StateMachine);
        InputProcessor = new InputProcessor();
        PlayerMovement = new PlayerMovement(Rigidbody, PlayerConfiguration);
    }

    void Start()
    {
        StateMachine.Init(States.IDLESTATE);
    }

    void Update()
    {
        StateMachine.state.Update();
        CurrentState.text = StateMachine.state.ToString();
    }

    private void FixedUpdate() 
    {
        StateMachine.state.FixedUpdate();
    }

    private void LateUpdate()
    {
        StateMachine.state.LateUpdate();
    }
}
