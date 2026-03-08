using UnityEngine;
using UnityEngine.UI;

public class ClickAnimal : MonoBehaviour
{
     public Image dialogueBox;
     public Dialogue dialogueScript;
     private PlayerController movementScript;

    //public GameObject player; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       dialogueBox.enabled = false;
       GetComponent<BoxCollider>();

       //movementScript = player.GetComponent<PlayerController>();

       //GetComponent<Dialogue>.StartDialogue();
    }

   
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            if(dialogueScript.index < dialogueScript.lines.Length - 1)
            {
                dialogueBox.enabled = true;
            }
            else 
            {
                dialogueBox.enabled = false;
            }
            
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Dialogue box starts");
            if(dialogueScript.index < dialogueScript.lines.Length - 1)
            {
                dialogueBox.enabled = true;
                PlayerController[] moveScript = FindObjectsOfType<PlayerController>();
                foreach(PlayerController scriptInstance in moveScript)
                {
                    scriptInstance.pause = true;
                    Debug.Log("paused movement");
                }
            }
            else 
            {
                dialogueBox.enabled = false;
                movementScript.pause = false;
            }
        }
    }

   /*void OnMouseDown()
   {
        dialogueBox.enabled = true;
        Debug.Log("enabled cloud");
   }*/
}
