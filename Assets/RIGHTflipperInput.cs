using UnityEngine;
using System.Collections;

public class RIGHTflipperInput : MonoBehaviour
{

    public float force;
    Rigidbody2D flipper;


    void Start()
    {

        flipper = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            flipper.AddTorque(force);
        }

    }
}