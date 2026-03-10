using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;


public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] lines;
    public float textSpeed;

    public int index;

    public bool typing = false;

    public Camera dialogueCam;

    public GameObject player;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && typing) 
        {
            //next click will go down the index with # of lines in dialogue
            if(text.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                text.text = lines[index];    
            }
        }
    }

     /* void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartDialogue();
            Debug.Log("Dialogue writing starts");
        }
    }*/


    public void StartDialogue()
    {
        //will start with the first line in the index
        index = 0;
        StartCoroutine(TypeLine());
        typing = true;
        dialogueCam.gameObject.SetActive(true);
        player.SetActive(false);
    }

    IEnumerator TypeLine()
    {
        //will type each character out 1 by 1
        foreach (char c in lines[index].ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        //if the index will continue to increase
        if(index < lines.Length -1)
        {
            index++;
            text.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialogueCam.gameObject.SetActive(false);
            player.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
