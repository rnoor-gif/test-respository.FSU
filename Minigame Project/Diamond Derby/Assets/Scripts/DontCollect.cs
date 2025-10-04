using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DontCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("Game Over! you hit a barrel!");
    }
}
