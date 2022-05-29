using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogText;
    public Animator animator;
    private static int flag;
    public GameObject dialoguePanel;
    public Queue<string> sentences;
    public GameObject testPanel;

    private void Awake()
    {
        flag = 0;
    }
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
           
        }

       DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
       
        if (sentences.Count == 0)
        {
            if(ScoreScript.HarmfulCount >= 2 && flag!=1)
            {
                testPanel.SetActive(true);
                flag = 1;
            }
           
            EndDialogue();
            return;
        }
       
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        
        animator.SetBool("IsOpen", false);
        dialoguePanel.SetActive(false);
        StartCoroutine(DelaySetActive());
    }

    private IEnumerator DelaySetActive()
    {
        
        yield return new WaitForSeconds(0.5f);
    }
}
