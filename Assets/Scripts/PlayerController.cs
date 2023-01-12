using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float playerMoveSpeed = 2f;
    public float playerMoveSpeedMax = 6f;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        if (playerRb.velocity.magnitude > playerMoveSpeedMax)
        {
            playerRb.velocity = Vector3.ClampMagnitude(playerRb.velocity, playerMoveSpeedMax);
        }

        if (Input.GetButton("Vertical") && Input.GetButton("Horizontal"))
        {
            playerMoveSpeed = 1.5f;
            playerRb.AddForce(Vector3.forward * verticalInput * playerMoveSpeed);
            playerRb.AddForce(Vector3.right * horizontalInput * playerMoveSpeed);

        }
        else
        {
            playerMoveSpeed = 2f;
            playerRb.AddForce(Vector3.forward * verticalInput * playerMoveSpeed);
            playerRb.AddForce(Vector3.right * horizontalInput * playerMoveSpeed);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Collided with enemy! " + gameObject.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }
}