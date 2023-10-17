using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : Subject
{
    public int clues = 0;

    [SerializeField] private Text clueText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Clue"))
        {
            Destroy(collision.gameObject);
            clues++;
            clueText.text = "Clues: " + clues;
            NotifyObservers();
        }
    }

}
