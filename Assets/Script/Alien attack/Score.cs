using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int alien;
    public Text scoreText;

    private void Start()
    {
        alien= 0;
    }
    

    void Update()
    {
        scoreText.text = "—бито: " + alien;
    }
}
