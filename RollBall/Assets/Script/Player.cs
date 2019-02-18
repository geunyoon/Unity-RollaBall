using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public Text scoreText;
    public Text winText;
    public float jumpPower;
    public GameObject restartButton, youWin;

    private Rigidbody rb;
    private int score;
    private bool isGrounded;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScoreText();
        //score
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
        if (other.gameObject.CompareTag("Goal"))
        {
            Time.timeScale = 0;
            youWin.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
    }
    void SetScoreText ()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void OnCollisionStay(Collision collision)
    {
        if(!collision.gameObject.CompareTag("Ground"))
        {
            return;
        }
        isGrounded = true;
        //collision with ground only count
    }
    private void Update()
    {
        if(Input.GetButton("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            isGrounded = false;
        }
        //calculating jump force and making isGrounded = false as soon as jump
    }
}