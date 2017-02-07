using UnityEngine;
using System.Collections;

public class ballSpawn : MonoBehaviour
{

    public Transform pos;
    public GameObject obj;
    public int lives = 0;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.CompareTag("Player") && lives < 3)
        {
            GameObject.Find("doorTrigger").GetComponent<boxAppear>().count = 0;
            Destroy(GameObject.Find("bounceBox(Clone)"));
            Instantiate(obj, pos.position, pos.rotation);
            lives++;

        }

    }

}
