using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawning : MonoBehaviour
{
    public GameObject clue1;
    public GameObject clue2;
    public GameObject clue3;
    void Start()
    {
        int clue = Random.Range(1, 3);

        if (clue == 1)
        {
            clue1.SetActive(true);
        }
        else if(clue == 2)
        {
            clue2.SetActive(true);
        }
        else if(clue == 3)
        {
            clue3.SetActive(true);
        }
    }
}
