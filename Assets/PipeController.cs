using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{   
    public float PipeSpeed = 1.5f;

    private void Update() {
        if (BirdController.Started) {
            transform.Translate(PipeSpeed * Time.deltaTime * Vector3.left);
        } // figure out a way to optimize this! (if cond every frame not very good prob)           
    }
}
