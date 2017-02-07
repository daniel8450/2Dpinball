using UnityEngine;
using System.Collections;

public class boxAppear : MonoBehaviour
{

    public Transform pos;
    public GameObject obj;
    public int count = 0;

    void OnTriggerEnter2D(Collider2D col)
    {
        

        if (col.CompareTag("Player") && count < 1)
        {
            Instantiate(obj, pos.position, pos.rotation);
            count++;

        }

    }

    }
