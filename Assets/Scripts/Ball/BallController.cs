using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    private Rigidbody rig;
    public Vector3 speed;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Destroyer")
        {
            Destroy(this.gameObject);
        }

    }
}
