using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public static int Backid;

    public void buttonBack()
    {
        SceneManager.LoadScene(Backid);
    }
}
