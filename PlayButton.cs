using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButton : MonoBehaviour { 
        
public void PlayGame()
{
        //create an entry
        Debug.Log("Playgame was pressed");
        
        //move to game scene
        SceneManager.LoadScene("Game");
    }
}
