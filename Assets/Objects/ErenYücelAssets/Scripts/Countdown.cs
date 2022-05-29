using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public  float timeRemaining;
    public static int flag;
    public  int second=1;
    public TextMeshProUGUI countdownText;
    public GameObject endPanel;
    public GameObject bossDialog;
    public GameObject ChefDialog;

    private void Awake()
    {
        countdownText.enabled = false;
        timeRemaining = 150;
        flag = 0;

    }
    private void Update()
    {
        if (flag == 1)
        {
            countdownText.enabled = true;
            StartCoroutine(CountdownStart());
            CountdownCont();
        }
       


    }

    private void CountdownCont()
    {

       
        if (timeRemaining > 0)
        {
            if (bossDialog.activeInHierarchy )
            {
                return;
            }
            else
            {
                Time.timeScale = 1;
                timeRemaining -=   Time.deltaTime;
                second = (int) timeRemaining;
                countdownText.text = second.ToString();
                if (ScoreScript.count == 12)
                {
                    Time.timeScale = 0;
                    ScoreScript.remainingPoint = second * 10;
                }
            }
        }
        if (second == 0)
        {
            ScoreScript.flag = 1;
            Time.timeScale = 0;
            endPanel.SetActive(true);
        
        }
        
    }
    public IEnumerator CountdownStart()
    {
        yield return new WaitForSeconds(3f);
      
    }

 

  
        }
