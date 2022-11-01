using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPrompts : MonoBehaviour
{

    public GameObject player;

    private PlayerLife playerLife;
    private string txt;
    //private TMP_InputField tmpif;
/*
    // Start is called before the first frame update
    void Start()
    {
        //tmpif = GetComponent<TMP_InputField>();
        playerLife = player.GetComponent<PlayerLife>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerLife.getDead() == true){
            txt.text="Nice one!";
            Debug.Log("dead checked");
        }

        txt.text="";
    }
    */
}
