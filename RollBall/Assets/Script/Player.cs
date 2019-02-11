using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public Text scoreText;
    public Text winText;

    private Rigidbody rb;
    private int score;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
        //score
        winText.text = "";
        //display nothing in win text when game start
    }
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        //putting the keyboard input
        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        rb.AddForce (movement * speed);
        //adjusting speed of player
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            //removing the Collectable object in collision
            score = score + 1;
            SetScoreText();
            //tracking score
        }
    }
    void SetScoreText ()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}