using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuidelinePageControl : MonoBehaviour
{
    public GameObject EssentialItemsObject;
    public GameObject HarmfulItemsObject;
    

    // Update is called once per frame
    
    public void NextButton()
    {
        HarmfulItemsObject.SetActive(true);
        EssentialItemsObject.SetActive(false);
    }

    public void BackButton()
    {
        HarmfulItemsObject.SetActive(false);
        EssentialItemsObject.SetActive(true);
    }

}
