using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOnePanelSettings : MonoBehaviour
{
    public GameObject guideLinePanel;


    public void  GuidelineShow()
    {
        guideLinePanel.SetActive(true);
    }
    public void GuidelineClose()
    {
        guideLinePanel.SetActive(false);
    }
}
