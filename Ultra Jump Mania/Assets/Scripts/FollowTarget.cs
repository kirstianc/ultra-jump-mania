using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(target.position.x - 2*offset.x, target.position.y + offset.y, offset.z);

        /* Unused code for making camera move more in direction player facing but not working right lol
        
        if(target.tag=="Player"){
            if(!target.gameObject.GetComponent<CharacterController2D>().getFacingRight()){
                transform.position = new Vector3(target.position.x - 2*offset.x, target.position.y + offset.y, offset.z);
            }else{
                transform.position = new Vector3(target.position.x + 2*offset.x, target.position.y + offset.y, offset.z); 
            }
        }else{
            transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z); // Camera follows the target with specified offset position
        }
        */
    }
}
