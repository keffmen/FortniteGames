using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class Button : MonoBehaviour
{
    [SerializeField]
    public GameObject Prefab;
    public GameObject Canvas;
    [SerializeField]

    public void OnMouseEnter()
    {
        GameObject camera = GameObject.Find("Main Camera");
        var Play = camera.GetComponent<UnityEngine.Video.VideoPlayer>();
        var Backgroun = Instantiate(Prefab);
        Backgroun.transform.SetParent(Canvas.transform, false);
        Play.Pause();
    }

    public void OnMouseExit()
    {
        GameObject camera = GameObject.Find("Main Camera");
        var Play = camera.GetComponent<UnityEngine.Video.VideoPlayer>();
        Play.Play();
        var Backgroun = GameObject.FindWithTag("Background");
        Destroy(Backgroun);
    }
}
