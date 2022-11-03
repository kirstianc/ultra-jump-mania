using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trillSpawn : MonoBehaviour
{
    public GameObject prefab;
    public GameObject player;
    private float spawnTime;

    private Quaternion rotation;

    void Start(){
        spawnTime = 2f;
    }

    void Update()
    {
        spawnTime -= Time.deltaTime;

        if(spawnTime<=0f){
            spawnTime=2.0f;
            rotation=player.transform.rotation*Quaternion.Euler(0,0,90);
            Instantiate(prefab, v3random(), rotation);
        }   
    }

    Vector3 v3random(){
        return new Vector3(player.transform.position.x+8, player.transform.position.y+Random.Range(-3, 3), player.transform.position.z);
    }

}
