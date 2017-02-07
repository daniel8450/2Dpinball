using System.Collections;
using UnityEngine;
using UnityEngine.UI;



public class pointManager : MonoBehaviour {


    public Text scoreText;
    public float scoreCounter;

    void Update()
    {
        scoreText.text = "Score: " + scoreCounter;

    }
}
