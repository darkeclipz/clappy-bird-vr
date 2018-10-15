using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class MicrophoneInput : MonoBehaviour
{
    public float sensitivity = 100;
    public float loudness = 0;

    private bool started = false;

    private new AudioSource audio;
    
    void Start()
    {
        //foreach (string deviceName in Microphone.devices)
        //{
        //    Debug.Log("Name: " + deviceName);
        //}

        audio = GetComponent<AudioSource>();

        var device = Microphone.devices[0];

        Debug.Log("device: " + device);

    
        audio.clip = Microphone.Start(null, true, 10, 44100);

        audio.loop = true; // Set the AudioClip to loop
        audio.mute = true; // Mute the sound, we don't want the player to hear it
        audio.Play(); // Play the audio source!
    }

    void Update()
    {
        var device = Microphone.devices[0];
        if (!(Microphone.GetPosition(null) > 0) && !started)
        {
            started = true;
            audio.Play();
        }

        loudness = GetAveragedVolume() * sensitivity;
    }

    float GetAveragedVolume()
    {
        float[] data = new float[256];
        float a = 0;
        audio.GetOutputData(data, 0);
        foreach (float s in data)
        {
            a += Mathf.Abs(s);
        }
        //Debug.Log("AveragedVolume: " + (a / 256));
        return a / 256;
    }
}