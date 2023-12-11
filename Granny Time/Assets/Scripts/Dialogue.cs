using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public TMP_Text nameText;
    public GameObject granny1; 
    public GameObject granny2;
    public GameObject you1;
    public GameObject you2;
    public GameObject bg;
    public string[] lines;
    public float textSpeed;

    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < 1)
        {
            nameText.text = "You";
            you1.SetActive(true);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else if (index < 3 && index > 0)
        {
            nameText.text = "Grammy";
            you1.SetActive(false);
            granny1.SetActive(true);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else if (index < 4 && index > 2)
        {
            nameText.text = "You";
            granny1.SetActive(false);
            you2.SetActive(true);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else if (index < 6 && index > 3)
        {
            nameText.text = "Grammy";
            granny2.SetActive(true);
            you2.SetActive(false);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            bg.SetActive(false);
        }
    }
}
