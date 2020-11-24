using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Microph : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
        
    }

    public void Record()
    {
        audioSource.clip = Microphone.Start(null, false, 10, 44100);
    }

    public void Play()
    {
        audioSource.Play();
    }

    public void EndRecording()
    {
        Microphone.End(null);
    }
}
