using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    static bool press;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(manage);
        GetComponentInChildren<Text>().text = "Pause/Resume";
    }
   void manage() {
     if (!press) {
       Debug.Log("Reconoce");
       controladorjuego.comenzar();
       press = true;
     } else {
       Debug.Log("Deja de reconocer");
       controladorjuego.pause();
       press = false;
     }
  
   }
    // Update is called once per frame
    void Update()
    {
        
    }
}
