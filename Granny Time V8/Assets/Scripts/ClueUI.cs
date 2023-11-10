using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueUI : MonoBehaviour
{
    public GameObject clue1;
    public GameObject clue2;
    public GameObject clue3;
    public GameObject clue4;
    public GameObject bG;
    public GameObject bGS;

    PassData pd = new PassData();
    int[] clues = {7, 7, 7, 7};

    void Start()
    {
        clues = pd.ChooseClues();
    }
    public void ClickClues()
    {
        bG.SetActive(true);

        if (clues[0] < 1)
        {
            clue1.SetActive(true);
        }

        if (clues[1] < 2)
        {
            clue2.SetActive(true);
        }

        if (clues[2] < 3)
        {
            clue3.SetActive(true);
        }

        if (clues[3] < 4)
        {
            clue4.SetActive(true);
        }
    }

    public void Return()
    {
        clue1.SetActive(false);
        clue2.SetActive(false);
        clue3.SetActive(false);
        clue4.SetActive(false);
        bG.SetActive(false);
    }

    public void ViewStories()
    {
        bGS.SetActive(true);
    }

    public void ReturnStories()
    {
        bGS.SetActive(false);
    }
}
