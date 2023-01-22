using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Click : MonoBehaviour
{
    public void Alien_attack()
    {
        Back.Backid = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("alien attack");
    }
}
