using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlayerMove : MonoBehaviour
{
    public float speed = 8;
    public Rigidbody rb;
    public GameManager gameManager;

    Vector3 move;
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * Time.fixedDeltaTime);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            gameManager.GameOver();
        }
    }
}
