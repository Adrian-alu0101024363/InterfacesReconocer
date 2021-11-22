using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swear : MonoBehaviour
{
  [SerializeField] public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "";
        controladorjuego.swearing += Swear;
    }
    void Swear(string words) {
      if (words == "ばかみたい") {
        texto.text = "Don't swear";
        controladorjuego.playAudio();
        //controladorjuego.playVideo();
      } else {
        texto.text = words;
      }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
