using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public float Progress = 0;
    public Image Progressbar;

    private void Start()
    {
        Progressbar.fillAmount = Progress;
    }

    public void OnClickProgressBar()
    {
        Progress += 0.1f;
        Progressbar.fillAmount = Progress;
         
        if(Progress >= 1)
        {
            SceneManager.LoadScene(0);
        }
    }

}
