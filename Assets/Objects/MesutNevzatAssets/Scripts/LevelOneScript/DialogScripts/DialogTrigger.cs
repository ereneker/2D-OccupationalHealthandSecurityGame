using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public GameObject dialogWindow;
    public void TriggerDialog()
    {

        FindObjectOfType<DialogManager>().StartDialogue(dialogue);
        dialogWindow.SetActive(true);
    }
}
