using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Player"){
            CompleteLevel();
            Debug.Log("collision with player");
        }
    }

    private void CompleteLevel(){
        SceneManager.LoadScene("level1",LoadSceneMode.Single);
        Debug.Log("load level1");
    }
}
