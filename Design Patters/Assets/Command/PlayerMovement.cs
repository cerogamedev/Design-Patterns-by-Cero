using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public void HandleMovement(Vector3 movement)
    {
        transform.position += movement;
    }
}