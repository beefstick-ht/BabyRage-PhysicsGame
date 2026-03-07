using UnityEngine;
using UnityEngine.UI;

public class ClickAnimal : MonoBehaviour
{
     public Image dialogueBox;
     public Dialogue dialogueScript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       dialogueBox.enabled = false;
       //GetComponent<Dialogue>.StartDialogue();
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(dialogueScript.index < dialogueScript.lines.Length - 1)
            {
                dialogueBox.enabled = true;
            }
            else 
            {
                dialogueBox.enabled = false;
            }
            
        }
    }

   /*void OnMouseDown()
   {
        dialogueBox.enabled = true;
        Debug.Log("enabled cloud");
   }*/
}
