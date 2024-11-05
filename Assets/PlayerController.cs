using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D FlappyRigidbody;
    public bool Started;

    private void Start () 
    {
        FlappyRigidbody = GetComponent<Rigidbody2D>();
        Started = false;
    }

    private void Update () {
        if (Input.GetKeyDown("space") && Started) {
            FlappyRigidbody.velocity = new Vector2(FlappyRigidbody.velocity.x, 5f);
        } else if (Input.GetKeyDown("space") && !Started) {
            Started = true;
            FlappyRigidbody.gravityScale = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Pipe") || col.CompareTag("Ground")) {
            Time.timeScale = 0;
        }
    }
}
