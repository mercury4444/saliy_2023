using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemChecker : MonoBehaviour
{
    public AudioClip OkSound, BoomSound;
    
    public int score;

    public GameObject ScoreObject;

    Text scoreText;




    void Start()
    {
        scoreText = ScoreObject.GetComponent<Text>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Good")
        {
            score = score + 10;

            scoreText.text = score.ToString();

            AudioSource.PlayClipAtPoint(OkSound, other.transform.position);

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Bad")
        {
            score = score - 10;

            scoreText.text = score.ToString();

            AudioSource.PlayClipAtPoint(BoomSound, other.transform.position);

            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
