using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private GameObject panel;

    public void StartGame(){
        Time.timeScale=1;
        SceneManager.LoadScene("tutorial",LoadSceneMode.Single);
    }

    public void MainMenu(){
        SceneManager.LoadScene("Title",LoadSceneMode.Single);
    }

    public void ExitGame(){
        Application.Quit();
    }

}
