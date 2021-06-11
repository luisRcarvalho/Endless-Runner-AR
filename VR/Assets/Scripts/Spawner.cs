using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] obstaclePrefab;
    public float spawntimer = 1f;
    public float timer = 0;

    void Update()
    {
        if(timer > spawntimer)
        {
            int random = Random.Range(0, obstaclePrefab.Length);

            GameObject obs = Instantiate(obstaclePrefab[random]);
            obs.transform.position = transform.position + new Vector3(0, 0, 0);
            Destroy(obs, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
