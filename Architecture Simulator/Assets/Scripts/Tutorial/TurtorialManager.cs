using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurtorialManager : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource tutorialAudioSource;
    public AudioClip[] tutorialAudio;

    int numTeleportPickUps = 0;
    int hubButtonPresses = 0;
    int numObjectPickups = 0;
    int numPlaceObject = 0;

    private void Start()
    {
        tutorialAudioSource.PlayOneShot(tutorialAudio[0]);
        numTeleportPickUps = 0;
        hubButtonPresses = 0;
        numObjectPickups = 0;
        numPlaceObject = 0;
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
        numTeleportPickUps++;

        if (numTeleportPickUps == 1)
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

    public void SpawnObjectAudio()
    {
        numObjectPickups++;

        if(numObjectPickups == 1)
        {
            tutorialAudioSource.PlayOneShot(tutorialAudio[4]);
        }
    }

    public void PlaceObjectAudio()
    {
        numPlaceObject++;

        if( numPlaceObject == 1)
        {
            tutorialAudioSource.PlayOneShot(tutorialAudio[5]);
        }
    }

    public void LoadScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}
