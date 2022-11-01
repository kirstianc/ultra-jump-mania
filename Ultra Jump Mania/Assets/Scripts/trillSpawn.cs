using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trillSpawn : MonoBehaviour
{
    public GameObject prefab;
    public GameObject player;
    public float spawnTime;

    void Update()
    {
        spawnTime -= Time.deltaTime;

        if(spawnTime<=0f){
            spawnTime=4.0f;
            Instantiate(prefab, v3random(), player.transform.rotation.Euler(0,90,0));
        }   
    }

    Vector3 v3random(){
        return new Vector3(player.transform.position.x + 5, Random.Range(-5, 5), player.transform.position.z);
    }

}
