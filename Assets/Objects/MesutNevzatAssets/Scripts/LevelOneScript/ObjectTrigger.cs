using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public static string nameofobj;
    public Sprite tick;
    public Image GuidelineBox;
    public GameObject interactionButton;
    private bool isInsideTrigger = false;
    
    public void Start()
    {

    }

    private void Update()
    {


        if (isInsideTrigger) {
            if (Input.GetKeyDown(KeyCode.E))
            {
             ScoreScript.score += 100;
                ScoreScript.count++;
                if(gameObject.tag == "harmfulObject")
                {
                    ScoreScript.HarmfulCount++;
                }
                gameObject.SetActive(false);
             GuidelineBox.sprite = tick;
                isInsideTrigger = false;
                interactionButton.SetActive(true);     
            }
            
        }
        if (interactionButton.activeInHierarchy)
        {
            Invoke("Action", 1.5f);
        }
        
    }
    private void Action()
    {

        interactionButton.SetActive(false);

    }



 

    private void OnTriggerStay2D(Collider2D collision)
    {

        if(collision.tag == "Player") {
          
                isInsideTrigger = true;
        }
    }
  

}

