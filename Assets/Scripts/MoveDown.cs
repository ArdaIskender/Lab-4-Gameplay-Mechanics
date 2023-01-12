using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private Rigidbody enemyRb;
    public float enemyMoveSpeed = 1.1f;
    public float enemyMoveSpeedMax = 3f;
    // Start is called before the first frame update
    private void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        enemyRb.AddForce(Vector3.back * enemyMoveSpeed,ForceMode.Acceleration);

        if (enemyRb.velocity.magnitude > enemyMoveSpeedMax)
        {
            enemyRb.velocity = Vector3.ClampMagnitude(enemyRb.velocity, enemyMoveSpeedMax);
        }
    }
}
