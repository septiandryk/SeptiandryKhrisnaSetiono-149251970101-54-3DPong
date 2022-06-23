using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPosition2;
    public int spawnInterval;

    private float timer;

    public void spawnBall()
    {
        Instantiate(ball, spawnPosition2);
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
