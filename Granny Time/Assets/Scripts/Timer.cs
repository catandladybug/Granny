using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour, IObserver
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] Subject _dataSubject;
    [SerializeField] float remainingTime;

    public int clues;
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

    void Update()
    {
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (remainingTime < 0 || clues == 4) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
