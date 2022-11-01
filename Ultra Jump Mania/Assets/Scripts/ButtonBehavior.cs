using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{

    public string buttonType;
/*
    void OnMouseDown(){
        if(buttonType == "start"){
            StartGame();
        }else if(buttonType == "exit"){
            ExitGame();
        }
    }
*/
    void StartGame(){
        SceneManager.LoadScene("tutorial",LoadSceneMode.Single);
    }

    void ExitGame(){
        Application.Quit();
    }
}
