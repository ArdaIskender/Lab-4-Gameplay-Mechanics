using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float playerMoveSpeed = 2f;
    public float playerMoveSpeedMax = 6f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(Vector3.forward * verticalInput * playerMoveSpeed);
        playerRb.AddForce(Vector3.right * horizontalInput * playerMoveSpeed);

        if (playerRb.velocity.magnitude > playerMoveSpeedMax)
        {
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, playerMoveSpeedMax);
        }
    }
}
