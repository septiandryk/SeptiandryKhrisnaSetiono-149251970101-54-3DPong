using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController2 : MonoBehaviour
{
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Ball")
        {
            manager.AddScore2(1);
        }
    }

}
