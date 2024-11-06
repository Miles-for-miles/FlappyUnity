using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float SpawnWait = 2f;
    public float SpawnInbetween = 3f;

    
    public GameObject PipePrefab;

    private IEnumerator Start() {
        yield return new WaitUntil(() => BirdController.Started == true);
        InvokeRepeating("Spawn", SpawnWait, SpawnInbetween);
    }

    private void Spawn() {
        GameObject NewPipe = Instantiate(PipePrefab, new Vector2(-2.5f, Random.Range(-1f, 2f)), Quaternion.identity);
        Destroy(NewPipe, 10f);
    }
}
