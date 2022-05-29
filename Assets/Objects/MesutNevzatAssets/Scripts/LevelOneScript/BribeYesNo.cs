using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BribeYesNo : MonoBehaviour
{
    public GameObject yesnoW;
    public GameObject bribeW;
    
    public void OpenbribeW()
    {
        bribeW.SetActive(true);
        yesnoW.SetActive(false);
    }

    public void ClosebribeW()
    {
        yesnoW.SetActive(false);
    }
}
