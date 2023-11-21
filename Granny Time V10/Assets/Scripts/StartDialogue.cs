using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialogue : MonoBehaviour
{
    public class StartScreen : MonoBehaviour
    {
        public GameObject dialogue;

        public void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                dialogue.SetActive(true);
            }
        }
    }
}
