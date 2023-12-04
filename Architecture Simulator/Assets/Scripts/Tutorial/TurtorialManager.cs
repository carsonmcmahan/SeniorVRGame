using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtorialManager : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource tutorialAudioSource;
    public AudioClip[] tutorialAudio;

    // Start is called before the first frame update

    public void StartTutorial(GameObject canvas)
    {
        canvas.SetActive(false);

        // play audio 
    }

    public void SpawnHouse(GameObject house)
    {
        house.SetActive(true);
    }
}
