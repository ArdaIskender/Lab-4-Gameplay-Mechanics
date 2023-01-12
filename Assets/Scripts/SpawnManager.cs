using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("SpawnEnemies", 2f, 2f);
    }

    private void SpawnEnemies()
    {
        Vector3 randomLoc = new(Random.Range(-5, 5), 0, 5);

        Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], randomLoc, Quaternion.identity);
    }
}
