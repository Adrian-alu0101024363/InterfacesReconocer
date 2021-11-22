using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Text;
using System.Linq;
using System;
using UnityEngine.UI;

public class dictation : MonoBehaviour
{
  private DictationRecognizer dictationRecognizer;
    // Start is called before the first frame update
    void Start()
    {
        dictationRecognizer = new DictationRecognizer();
        dictationRecognizer.DictationResult += Resolution;
        dictationRecognizer.DictationHypothesis += hypo;
        dictationRecognizer.DictationComplete += completo;
        dictationRecognizer.DictationError += errores;
        controladorjuego.dictStart += comienza;
        controladorjuego.dictStop += termina;
        //dictationRecognizer.Start();
        //Debug.Log(dictationRecognizer.Status);
    }
    void comienza() {
      Debug.Log("dicta");
      dictationRecognizer.Start();
    }
    void termina() {
      Debug.Log("Deja de dictar");
      dictationRecognizer.Stop();
    }
    void Resolution(string text, ConfidenceLevel confidence) {
      Debug.Log(text);
      Debug.Log(dictationRecognizer.Status);
      controladorjuego.swearing(text);
        //Sacar sonido o algo asi
    }
    void hypo(string text) {

    }
    void completo(DictationCompletionCause cause) {

    }
    void errores(string error, int hresult) {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
