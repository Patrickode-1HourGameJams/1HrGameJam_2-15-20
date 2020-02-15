using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private Collider coll;

    public float maxVelocity = 5;
    public float accelSpeed = 1;

    void Update()
    {
        //If the WASD keys are released, jump in the corresponding direction.
        if (Input.GetKeyUp(KeyCode.W))
        {
            ApplyMoveInput(Vector3.forward);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            ApplyMoveInput(Vector3.down);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            ApplyMoveInput(Vector3.right);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            ApplyMoveInput(Vector3.left);
        }
    }

    /// <summary>
    /// Applies velocity in the given direction.
    /// </summary>
    /// <param name="forceDir">The direction to move in.</param>
    private void ApplyMoveInput(Vector3 forceDir)
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity + forceDir * accelSpeed, maxVelocity);
    }
}
