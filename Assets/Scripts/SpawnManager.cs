using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefabs[0],transform.parent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
