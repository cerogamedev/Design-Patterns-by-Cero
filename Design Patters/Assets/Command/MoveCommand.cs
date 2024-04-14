using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private PlayerMovement player;
    private Vector3 movement;
    
    public MoveCommand(PlayerMovement player, Vector3 movement)
    {
        this.player = player;
        this.movement = movement;
    }
    public void Execute()
    {
        player.HandleMovement(movement);
    }

    public void Undo()
    {
        player.HandleMovement(-movement);
    }
}
