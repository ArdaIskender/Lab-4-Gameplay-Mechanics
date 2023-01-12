using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private readonly float outOfBound = 10f;

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.magnitude >= outOfBound)
        {
            Destroy(gameObject);
        }
    }
}
