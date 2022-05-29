using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasStartSettings : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject howtoPlayPanel;
    public GameObject settingsPanel;
        void Awake()
    {
        howtoPlayPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

   
  
}
