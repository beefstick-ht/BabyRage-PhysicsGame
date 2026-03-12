using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Sprite original;
    public Sprite fire;

    public void OnButtonClick(GameObject clickedbutton)
    {
        if(clickedbutton.CompareTag("Play"))
        {
            SceneManager.LoadScene("GameTest");
            Debug.Log("Game is now playing");
            //Play();
        }
        
        if(clickedbutton.CompareTag("Quit"))
        {
            Quit();
        }
    }



    /*public void Play()
    {
        SceneManager.LoadScene("GameTest");
        Debug.Log("Game is now playing");
    }*/

    public void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().sprite = fire;
    }

    public void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = original;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game is closing...");
    }
}
