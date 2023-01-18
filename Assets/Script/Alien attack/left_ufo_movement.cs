using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_ufo_movement : MonoBehaviour
{
    public float timeEnd = 0;
    public float speed = 0.1f;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Score.alien += 1;
    }


    private void FixedUpdate()
    {
        transform.Translate(Vector3.left* speed);
    }

    public void Update()
    {
        if (timeEnd >= 8)
        {
            Destroy(gameObject);
        }
        else
        {
            timeEnd+= Time.deltaTime;
        }
    }
}
