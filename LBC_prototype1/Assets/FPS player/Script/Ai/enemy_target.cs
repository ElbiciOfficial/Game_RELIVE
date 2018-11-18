using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_target : MonoBehaviour {

    public Transform target; //target
    public float speed; //speed
    public int rotationSpeed;
    bool playerinrange = false;

    void Update()
    {
    
        if(playerinrange == true)
        {
            transform.LookAt(target.transform);
            transform.Translate(0, 0, speed * Time.deltaTime);
        }     
        Debug.DrawLine(target.position, transform.position, Color.red);

        float dist = Vector3.Distance(target.position, transform.position);
        if (dist < 300)
        {
            // get the target direction:
            if (playerinrange == true)
            {
                Vector3 targetDir = target.position - transform.position;
                targetDir.y = 0; // kill any height difference to avoid tilting
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetDir), rotationSpeed * Time.deltaTime);
            }

            if (dist > 5)
            { // check min distance
              // only move to the target if farther than min distance
              //transform.position += transform.forward * moveSpeed * Time.deltaTime;
                playerinrange = true;

            }
            else if(dist < 1)
            {
                playerinrange = false;
            }
        }
    }
}
