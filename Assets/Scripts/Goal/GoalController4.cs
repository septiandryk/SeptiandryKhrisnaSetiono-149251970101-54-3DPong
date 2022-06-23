using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController4 : MonoBehaviour
{
    public ScoreManager manager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Ball")
        {
            manager.AddScore4(1);
        }
    }

}
