using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    public void OnButtonClick(GameObject clickedbutton)
    {
        if(clickedbutton.CompareTag("Play"))
        {
            Play();
        }
        
        if(clickedbutton.CompareTag("Quit"))
        {
            Quit();
        }
    }



    public void Play()
    {
        SceneManager.LoadScene("GameTest");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Game is closing...");
    }
}
