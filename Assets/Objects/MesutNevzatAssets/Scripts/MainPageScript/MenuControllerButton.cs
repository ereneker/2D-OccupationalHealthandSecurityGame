using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControllerButton : MonoBehaviour
{
    // Start is called before the first frame update
 
   
    public GameObject showPanel;

    // Update is called once per frame
   

    public void ShowMenu()
    {

        showPanel.SetActive(true);

    }

    public void CloseMenu()
    {
        showPanel.SetActive(false);
    }

}
