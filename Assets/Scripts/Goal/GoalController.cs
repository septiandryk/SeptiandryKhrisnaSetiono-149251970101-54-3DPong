using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Ball")
        {
            manager.AddScore1(1);
        }
    }

}
