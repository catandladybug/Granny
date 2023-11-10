using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndTExt : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public TMP_Text nameText;
    public GameObject mc1;
    public GameObject grammy1;
    public GameObject tom1;
    public GameObject linda1;
    public GameObject chad1;
    public GameObject clues;
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
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
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
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < 1)
        {
            nameText.text = "Grammy";
            grammy1.SetActive(true);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else if (index < 4 && index > 0)
        {
            nameText.text = "Tom";
            grammy1.SetActive(false);
            tom1.SetActive(true);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else if (index < 6 && index > 2)
        {
            nameText.text = "Linda";
            tom1.SetActive(false);
            linda1.SetActive(true);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else if (index < 9 && index > 5)
        {
            nameText.text = "Brad";
            linda1.SetActive(false);
            chad1.SetActive(true);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else if (index < 11 && index > 7)
        {
            nameText.text = "Jessica";
            chad1.SetActive(false);
            mc1.SetActive(true);
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        //if (index < lines.Length - 1)
        else
        {
            gameObject.SetActive(false);
            bg.SetActive(false);
        }
    }
}
