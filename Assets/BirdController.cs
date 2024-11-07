using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D FlappyRigidbody;
    public static bool Started;
    public int Score = 0;

    public TMP_Text ScoreText;

    private void Start () 
    {
        FlappyRigidbody = GetComponent<Rigidbody2D>();
        Started = false;
    }

    private void Update () {
        ScoreText.text = "Score: " + Score.ToString();

        if (Input.GetKeyDown("space") && Started) {
            FlappyRigidbody.velocity = new Vector2(FlappyRigidbody.velocity.x, 5f);
        } else if (Input.GetKeyDown("space") && !Started) {
            Started = true;
            FlappyRigidbody.gravityScale = 1;
            SinMove.DestroyStart();
        }
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Pipe") || col.CompareTag("Ground")) {
            Time.timeScale = 0;
        } else if (col.CompareTag("ScoreUp")) {
            Score += 1;
        }
    }
}
