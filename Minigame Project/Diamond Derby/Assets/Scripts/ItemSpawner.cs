using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    
    public GameObject[] itemPrefabs;
    private float MaxXrange = 9;
    private float MinXrange = -38;
    private float posY = 4.5f;
    private float posZ = 46;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomly", 3, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomly()
    {
        Vector3 Spawner = new Vector3(Random.Range(MaxXrange, MinXrange), posY, posZ);

        int itemIndex = Random.Range(0, itemPrefabs.Length);

        Instantiate(itemPrefabs[itemIndex], Spawner, itemPrefabs[itemIndex].transform.rotation);
    }
}
