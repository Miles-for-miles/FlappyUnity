using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SinMove : MonoBehaviour
{
    public float WaveSpeed = 1.3f;
    public float WaveSize = 100f;

    public static TextMeshProUGUI TMTrademark;

    private float WaveTimer;
    private Vector3 StartPosition;

    private void Start() {
        TMTrademark = GetComponent<TextMeshProUGUI>();
        StartPosition = transform.position;
    }


    private void Update() {
        WaveTimer += Time.deltaTime; // i <3 deltatime

        float NewY = StartPosition.y + Mathf.Sin(WaveTimer * WaveSpeed) * WaveSize;
        transform.position = new Vector3(StartPosition.x, NewY, StartPosition.z);
    }

    public static void DestroyStart () {
        TMTrademark.text = "";
    }
}
