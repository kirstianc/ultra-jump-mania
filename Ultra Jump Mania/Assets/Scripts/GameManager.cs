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
        SceneManager.LoadScene("tutorial",LoadSceneMode.Single);
    }

    public void ExitGame(){
        Application.Quit();
    }

}
