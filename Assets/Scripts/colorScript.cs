using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class colorScript : MonoBehaviour
{

    public GameObject obj;
    public Sprite change;
    public Sprite norm;




    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            obj.GetComponent<SpriteRenderer>().sprite = change;

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {

            obj.GetComponent<SpriteRenderer>().sprite = norm;
            GameObject.Find("pointmanager").GetComponent<pointManager>().scoreCounter += 50;

        }
    }

}
