using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Dice : MonoBehaviour {

    // Array of dice sides sprites to load from Resources folder
    public Sprite[] diceSides;
    public Image dice;
    public static int flag;
   
    // Reference to sprite renderer to change sprite
    public TextMeshProUGUI diceResult;
    public GameObject continueButton;
    public GameObject BribePagePanel;

    private void Awake()
    {
        flag = 0;
    }
    // Use this for initialization
    private void Start () {

        // Assign Renderer component
        //  rend = GetComponent<SpriteRenderer>();
        diceResult.enabled = false;
        continueButton.SetActive(false);
        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
     //    diceSides = Resources.LoadAll<Sprite>("Assets/DiceSides");
    }

    // If you left click over the dice then RollTheDice coroutine is started
    public void OnMouseDown()
    {
        if (flag != 1) { 
        StartCoroutine("RollTheDice");
        }
    }

    // Coroutine that rolls the dice
    private IEnumerator RollTheDice()
    {
        // Variable to contain random dice side number.
        // It needs to be assigned. Let it be 0 initially
        int randomDiceSide = 0;

        // Final side or value that dice reads in the end of coroutine
        int finalSide = 0;

        // Loop to switch dice sides ramdomly
        // before final side appears. 20 itterations here.
        for (int i = 0; i <= 20; i++)
        {
            // Pick up random value from 0 to 5 (All inclusive)
            randomDiceSide = Random.Range(0, 5);

            // Set sprite to upper face of dice from array according to random value
            dice.sprite = diceSides[randomDiceSide];

            // Pause before next itteration
            yield return new WaitForSeconds(0.05f);
        }

        // Assigning final side so you can use this value later in your game
        // for player movement for example
        finalSide = randomDiceSide + 1;
        if (finalSide <= 3)
        {
            diceResult.text = "Dice Result is:" + finalSide.ToString() + "\nYou're caught! -200P";
            ScoreScript.Bribepoint = -200;
        }
        else if (finalSide > 3){
            diceResult.text = "Dice Result is:" + finalSide.ToString() + "\nNice job ! +200P";
            ScoreScript.Bribepoint = 200;
        }
        // Show final dice value in Console
      
        diceResult.enabled = true;
        flag = 1;
        continueButton.SetActive(true);
       
    }


    public void ClosePage()
    {
        BribePagePanel.SetActive(false);
    }
}


