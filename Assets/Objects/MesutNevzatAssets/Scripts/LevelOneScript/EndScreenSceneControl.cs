using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenSceneControl : MonoBehaviour
{
    // Start is called before the first frame update

   
    public void BackToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
      
    }


}
