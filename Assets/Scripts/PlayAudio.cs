using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
//if using this script and no audiosource is applied, unity will add one

public class PlayAudio : MonoBehaviour
{
    public float fadeTimeInSeconds = .5f;

    private AudioSource audio;
    public BoxCollider bc;

    public GameObject fire;

    void Start()
    {
        {
            audio = GetComponent<AudioSource>();
        }
    }
   /* void Update()
    {
        if(fire.SetActive(true))
        {
            StartCoroutine(FadeAudio(true));
        }
        if(fire.SetActive(false))
        {
            StopAllCoroutines();
            StartCoroutine(FadeAudio(true));
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(FadeAudio(true));
            bc.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Hazard" ||other.tag == "PlinkoToken")
        {
            StopAllCoroutines();
            StartCoroutine(FadeAudio(true));

        }
    }



    private IEnumerator FadeAudio(bool fadeIn)
    {
        float timer = 0;
        //if fadein is true, set to 0, else set to 1
        float start = fadeIn ? 0 : audio.volume;
        //if fadeIn is true, set to 1, else set to 0
        float end = fadeIn ? 1 : 0;
        //? = true/false true : false

        if (fadeIn) audio.Play();
        while (timer < fadeTimeInSeconds)
        {
            audio.volume = Mathf.Lerp(start, end, timer / fadeTimeInSeconds);
            timer += Time.deltaTime;
            yield return null; //waits 1 frame; WaitForSeconds(x) is a cooldown
        }

        audio.volume = end;
        if (!fadeIn) audio.Pause();
    }

}
