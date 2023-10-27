using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private CreateBackground backgroundCreate;


    private void Awake()
    {
        backgroundCreate = FindObjectOfType<CreateBackground>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            backgroundCreate.CreateBg(transform.parent);
            Destroy(gameObject);
        }
    }
}
