using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject SuperMario1;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(SuperMario1.transform.position.x, SuperMario1.transform.position.y, -10f);
    }
}
