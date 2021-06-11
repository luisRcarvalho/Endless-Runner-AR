using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float speed = 5f;
    GameObject scoreUIText;

    private void Start()
    {
        scoreUIText = GameObject.FindGameObjectWithTag("ScoreText");

    }
    void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score.pontos++;
        }
    }
}
