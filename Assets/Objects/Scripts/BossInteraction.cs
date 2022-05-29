using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossInteraction : MonoBehaviour
{
    public GameObject interactionButton;
    private bool isInsideTrigger = false;
    public GameObject dialogPanel;
    public Dialogue dialogue;
    public Dialogue dialogue2;
    public Dialogue dialogue3;
    private static int flag;

    private void Awake()
    {
        flag = 0;
    }

    void Update()
    {
        if (isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogPanel.SetActive(true);
                if (ScoreScript.HarmfulCount < 2) {
   
                    FindObjectOfType<DialogManager2>().StartDialogue(dialogue);
                   
                }
                else if (ScoreScript.HarmfulCount >= 2 && flag != 1)
                {
                    FindObjectOfType<DialogManager2>().StartDialogue(dialogue2);
                    flag = 1;
                }
                else if (flag == 1)
                {
                    FindObjectOfType<DialogManager2>().StartDialogue(dialogue3);
                }


            }
        }
    }

   

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            isInsideTrigger = true;
            interactionButton.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            interactionButton.SetActive(false);
            isInsideTrigger = false;
        }
    }
}
