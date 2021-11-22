using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    public AudioSource audio;
    public bool alreadyPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        controladorjuego.playAudio += OnPlay;
        //audio.PlayOneShot(SoundToPlay, Volume);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnPlay() {
      if (!alreadyPlayed) {
        audio.PlayOneShot(SoundToPlay, Volume);
        alreadyPlayed = true;
      }
    }
}
