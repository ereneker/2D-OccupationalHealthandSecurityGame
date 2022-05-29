using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public static int score;
    public static int totalScore;
    public static int Bribepoint;
    public static int remainingPoint;
    public static int count;
    public static int flag;
    public TextMeshProUGUI objectPointText;
    public TextMeshProUGUI totalScoreText;
    public TextMeshProUGUI BribepointsText;
    public TextMeshProUGUI remainingPointText;
    public static int HarmfulCount;
    public GameObject endGameW;
    public GameObject timeIsUpEndGameW;
    void Awake()
    {
        score = 0;
        totalScore = 0;
        Bribepoint = 0;
        remainingPoint = 0;
        count = 0;
        flag = 0;
        HarmfulCount = 0;

    }
   
    

    // Update is called once per frame
    void Update()
    {
        totalScore = (score + Bribepoint + remainingPoint);
        objectPointText.text = "Score from object:" + score.ToString();
        BribepointsText.text = "Bribe Score: " + Bribepoint.ToString();
        remainingPointText.text = "Remaining Time * 10 point:" + remainingPoint.ToString();
        totalScoreText.text = "Total Score: " + totalScore.ToString();

        if (count == 12)
        { 
            endGameW.SetActive(true);      
        }
        if(flag==1)
        {
            timeIsUpEndGameW.SetActive(true);
        }
      
    }
}


