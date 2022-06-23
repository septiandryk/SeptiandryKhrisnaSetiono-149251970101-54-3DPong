using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text score1;
    public Text score2;
    public Text score3;
    public Text score4;

    public ScoreManager manager;

    // Update is called once per frame
    void Update()
    {
        score1.text = manager.score1.ToString();
        score2.text = manager.score2.ToString();
        score3.text = manager.score3.ToString();
        score4.text = manager.score4.ToString();
    }
}
