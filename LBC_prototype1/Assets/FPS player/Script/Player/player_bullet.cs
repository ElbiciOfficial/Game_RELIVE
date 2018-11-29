using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bullet : MonoBehaviour
{

    public float speed = 100f;
    public GameObject impacteffect;
    public int damage = 10;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,5 * speed * Time.deltaTime);

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Debug.Log(other.gameObject.tag);
            target target1 = other.transform.GetComponent<target>();

            if (target1 != null)
            {
                target1.takedamage(damage);
                if (target1.health <= 0)
                {
                    Destroy(other.gameObject);
                }

                var bullet = GameObject.Instantiate(impacteffect);
                bullet.transform.position = transform.position;
                Destroy(bullet, 2f);
                Destroy(this.gameObject);
            }
            //Debug.Log("enemy health: " + target1.health);
        }
        if (other.gameObject.tag == "static_obj")
        {
            Debug.Log(other.gameObject.tag);

            var bullet = GameObject.Instantiate(impacteffect);
            bullet.transform.position = transform.position;
            Destroy(this.gameObject);
            Destroy(bullet, 2f);
        }    
    }
}
