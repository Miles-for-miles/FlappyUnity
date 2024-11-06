using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{   
    public float PipeSpeed = 1.5f;
    public GameObject PipePrefab;

    public float SpawnWait = 2f;
    public float SpawnInbetween = 2f;

    private void Start() {
        InvokeRepeating("Spawn", SpawnWait, SpawnInbetween);
    }

    private void Update() {
        if (BirdController.Started) {
            transform.parent.transform.Translate(PipeSpeed * Time.deltaTime * Vector3.left);
        } // figure out a way to optimize this! (if cond every frame not very good)           
    }

    private void Spawn() {
        Instantiate(PipePrefab, new Vector2(-2.5f, Random.Range(-1f, 1f)), Quaternion.identity);
    }
}
