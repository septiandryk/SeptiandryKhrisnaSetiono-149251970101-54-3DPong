using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController3 : MonoBehaviour
{
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Ball")
        {
            manager.AddScore3(1);
        }
    }

}
