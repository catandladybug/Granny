using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IntoMem : MonoBehaviour
{
    public GameObject stopper;
    public GameObject endingDia;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            stopper.SetActive(true);
            endingDia.SetActive(true);
        }
    }
}



