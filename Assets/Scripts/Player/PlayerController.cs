using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int speed;
    private Rigidbody rig;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode upKey;
    public KeyCode downKey;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector3 GetInput()
    {
        if (Input.GetKey(leftKey))
        {
            return Vector3.left * speed;
        }
        if (Input.GetKey(rightKey))
        {
            return Vector3.right * speed;
        }
        if (Input.GetKey(upKey))
        {
            return Vector3.forward * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector3.back * speed;
        }
        return Vector3.zero;
    }

    private void MoveObject(Vector3 movement)
    {
        rig.velocity = movement;
    }

    public void PlayerDead()
    {
        this.gameObject.SetActive(false);
    }

}
