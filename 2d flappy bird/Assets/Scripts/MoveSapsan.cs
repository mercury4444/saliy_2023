using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSapsan : MonoBehaviour
{
    public float speed = 0.01f;
    
    void Update()
    {
        transform.Translate(Vector2.left * speed);  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "killer")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
