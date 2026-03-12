using UnityEngine;
using UnityEngine.UI;

public class DialogueWithTrigger : MonoBehaviour
{
    public Image dialogueBox;
    public Image nameTag;
    public Dialogue dialogueScript;
    
    public Camera dialogueCam;

    public GameObject player;


    void Start()
    {
        dialogueBox.enabled = false;
        nameTag.enabled = false;
        GetComponent<BoxCollider>();
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hazard")
        {
            Debug.Log("Dialogue box starts");
            if (dialogueScript.index < dialogueScript.lines.Length - 1)
            {
                dialogueBox.enabled = true;
                nameTag.enabled = true;
                dialogueScript.StartDialogue();
                player.SetActive(false);
                dialogueCam.gameObject.SetActive(true);
            }
            else
            {
                dialogueBox.enabled = false;
                nameTag.enabled = false;
            }
        }
    }
}