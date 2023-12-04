using System.Collections;
using System.Collections.Generic;
using Unity.Tutorials.Core.Editor;
using UnityEngine;

public class TurtorialManager : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource tutorialAudioSource;
    public AudioClip[] tutorialAudio;

    int numOfPickUps = 0;
    int hubButtonPresses = 0;

    private void Start()
    {
        tutorialAudioSource.PlayOneShot(tutorialAudio[0]);
        numOfPickUps = 0;
        hubButtonPresses = 0;
    }

    public void StartTutorial(GameObject canvas)
    {
        canvas.SetActive(false);

        // play audio 
        tutorialAudioSource.PlayOneShot(tutorialAudio[1]);
    }

    public void SpawnHouse(GameObject house)
    {
        house.SetActive(true);
    }

    public void PickedUpTablet()
    {
        numOfPickUps++;

        if (numOfPickUps == 1)
        {
            tutorialAudioSource.PlayOneShot(tutorialAudio[2]);
        }
    }

    public void AudioForMainHubTeleport()
    {
        hubButtonPresses++;

        if(hubButtonPresses == 1)
        {
            tutorialAudioSource.PlayOneShot(tutorialAudio[3]);
        }
    }
}
