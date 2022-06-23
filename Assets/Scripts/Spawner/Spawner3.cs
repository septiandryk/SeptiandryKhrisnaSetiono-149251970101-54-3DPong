using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPosition3;
    public int spawnInterval;

    private float timer;

    public void spawnBall()
    {
        Instantiate(ball, spawnPosition3);
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            spawnBall();
            timer -= spawnInterval;
        }
    }
}
