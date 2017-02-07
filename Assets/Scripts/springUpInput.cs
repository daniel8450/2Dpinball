using UnityEngine;
using System.Collections;

public class springUpInput : MonoBehaviour
{

    public float force;
    Rigidbody2D spring;


    void Start()
    {

        spring = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            spring.AddTorque(force);
        }

    }
}