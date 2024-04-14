using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    public void EnterState(PlayerController player)
    {
        Debug.Log("Entering idle state");
    }

    public void ExitState(PlayerController player)
    {
        Debug.Log("Exiting idle state");

    }

    public void UpdateState(PlayerController player)
    {
        if (player.IsWalking() && player.IsGrounded())
        {
            player.ChangeState(new WalkingState());
        }

    }
}
