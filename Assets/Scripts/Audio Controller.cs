using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public float fadeTimeInSeconds;
    public AudioMixerSnapshot unmutedSnapshot;
    public AudioMixerSnapshot mutedSnapshot;

    private AudioSource audio;
    private AudioMixer mixer;
    private float[] weights;
    private AudioMixerSnapshot[] snapshots;


    private void Start()
    {
        audio = GetComponent<AudioSource>();
        mixer = audio.outputAudioMixerGroup.audioMixer;

        snapshots = new AudioMixerSnapshot[]
        {
            unmutedSnapshot, //index 1
        mutedSnapshot //index 2
    };
        // make an array of size 2 (two values)
        weights = new float[2];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            audio.Play();
            weights[0] = 1;
            weights[1] = 0;
            mixer.TransitionToSnapshots(snapshots, weights, fadeTimeInSeconds);
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //turn unmuted ON
            weights[1] = 1;
            //turn unmuted OFF
            weights[0] = 0;
            mixer.TransitionToSnapshots(snapshots, weights, fadeTimeInSeconds);
        }
    }*/
}
