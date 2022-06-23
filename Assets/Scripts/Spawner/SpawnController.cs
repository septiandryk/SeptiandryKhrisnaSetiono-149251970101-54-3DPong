using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject ballController;
    public List<Transform> spawnLocations;
    public GameObject ball;
    public int spawnInterval;
    public int maxBallAmount;

    private float timer;


    public void spawnBall()
    {
        int randomIndex = Random.Range(0, spawnLocations.Count);
        Instantiate(ball, spawnLocations[randomIndex]);
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
