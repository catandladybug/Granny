using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreen : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject textScreen;

    public void StartGame()
    {
        startScreen.SetActive(false);
        textScreen.SetActive(true);
    }

    public void ExitGame()
    {

    }
}
