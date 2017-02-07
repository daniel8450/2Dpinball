using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sScore : MonoBehaviour
{

    public GameObject obj;

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            GameObject.Find("pointmanager").GetComponent<pointManager>().scoreCounter += 50;

        }


    }


}