using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogText;
    public GameObject startGame;
  //  public Animator animator;
    public GameObject dialoguePanel;
    public Queue<string> sentences;
    public GameObject chefCanvas;
   
  

    void Start()
    {
        
        sentences = new Queue<string>();
    }

    private void Update()
    {
        
    }
    public void StartDialogue(Dialogue dialogue)
    {
        
        startGame.SetActive(false);
      //  animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach ( string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {

        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
      string sentence =  sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence ( string sentence)
    {
        dialogText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {

        Countdown.flag = 1;
       // animator.SetBool("IsOpen", false);
        StartCoroutine(DelaySetActive());
    }

    private IEnumerator DelaySetActive()
    {
        dialoguePanel.SetActive(false);
        chefCanvas.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }
    
}
