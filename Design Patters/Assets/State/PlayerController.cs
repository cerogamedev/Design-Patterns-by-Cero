using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isWalking;
    [SerializeField] private bool isGrounded;

    private IState currentState;

    void Start()
    {
        currentState = new IdleState();
        currentState.EnterState(this);

    }

    void Update()
    {
        currentState.UpdateState(this);   
    }
    public void ChangeState(IState newState)
    {
        currentState.ExitState(this);
        currentState = newState;
        currentState.EnterState(this);
    }
    public bool IsWalking()
    {
        return isWalking;
    }
    public bool IsGrounded()
    {
        return isGrounded;
    }
}
