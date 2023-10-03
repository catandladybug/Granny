using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiarChoice : MonoBehaviour
{
    public GameObject winnerUI;
    public GameObject loserUI;
    public void Winner()
    {
        winnerUI.SetActive(true);
        loserUI.SetActive(false);
    }

    public void Loser()
    {
        loserUI.SetActive(true);
        winnerUI.SetActive(false);
    }
}
