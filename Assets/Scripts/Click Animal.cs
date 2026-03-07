using UnityEngine;
using UnityEngine.UI;

public class ClickAnimal : MonoBehaviour
{
     public Image dialogueBox;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       dialogueBox.enabled = false;
       //GetComponent<Dialogue>.StartDialogue();
    }

   
   void OnMouseDown()
   {
        dialogueBox.enabled = true;
   }
}
