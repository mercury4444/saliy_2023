using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force = 7.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
            
        }

        if (gameObject.transform.position.y < -6.11)
        {
            Thread.Sleep(500); SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
