using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGs : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.position = (player.transform.position * 0.95f);
    }
}
