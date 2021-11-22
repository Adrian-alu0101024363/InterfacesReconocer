using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dictbutton : MonoBehaviour
{
  static bool pressed;
    // Start is called before the first frame update
    void Start()
    {
      GetComponent<Button>().onClick.AddListener(manage);
    }
   void manage() {
     if (!pressed) {
       controladorjuego.dictStart();
       pressed = true;
     } else {
       controladorjuego.dictStop();
       pressed = false;
     }
   }
    // Update is called once per frame
    void Update()
    {
        
    }
}
