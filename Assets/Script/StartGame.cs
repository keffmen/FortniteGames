using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   public void Start_Game()
    {
        Back.Backid = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1); //Пока одна сцена , будет атака.
    }
}
