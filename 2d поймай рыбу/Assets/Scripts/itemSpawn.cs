using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawn : MonoBehaviour
{
    public GameObject RightSide;

    public GameObject[] items;

    public float startDelay, repeatRate;
    
    
    
    
    void Start()
    {
        InvokeRepeating("Spawn", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Spawn()
    {
        Vector3 pos = new Vector3(Random.Range(gameObject.transform.position.x, RightSide.transform.position.x), gameObject.transform.position.y, 0);

        Instantiate(items[Random.Range(0, items.Length)], pos, gameObject.transform.rotation);
    }
    
    
    
    
    
    void Update()
    {
        
    }
}
