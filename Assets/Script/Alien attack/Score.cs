using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int alien;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "—бито: " + alien;
    }
}
