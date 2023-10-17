using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassData : MonoBehaviour, IObserver
{
    [SerializeField] Subject _dataSubject;

    public GameObject empty;

    public static int clues;

    void Awake()
    {
        DontDestroyOnLoad(empty);
    }

    private void OnEnable()
    {
        _dataSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        _dataSubject.RemoveObserver(this);
    }

    public void OnNotify()
    {
        clues++;
    }

    public int[] ChooseClues()
    { 
        int a = 3;
        int[] clueNumber = {0, 1, 2, 3};

        clues = 4 - clues;
        //Debug.Log(clues);

        while (clues > 0)
        {
            //Debug.Log(clues);
            clueNumber[a] = 7;
            clues--;
            a--;
        }

        return clueNumber;
    }
}
