using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
  
   
    
    
    public GameObject[] importantObject;
    int i;
    int num;
    public void Start()
    {
        SpawnRandomObject();
    }


    public void SpawnRandomObject()
    {
        for (i = 0; i < 12; i++)
        {
            num = Random.Range(0, importantObject.Length); 
            if (importantObject[num].activeInHierarchy == false)
                importantObject[num].SetActive(true); 

          
        }
    }

    
}
