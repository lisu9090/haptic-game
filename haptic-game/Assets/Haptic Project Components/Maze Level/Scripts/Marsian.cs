using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marsian : MonoBehaviour
{
    public GameObject alien;
    public GameObject bullet;
    public float attackSpeed = 0.1f;
    public float bulletSpeed = 50f;
    float prevAttackSpeed;
    // Use this for initialization
    void Start()
    {
        prevAttackSpeed = attackSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        attackSpeed -= Time.fixedDeltaTime;
        if (attackSpeed <= 0f)
        {
            attackSpeed = prevAttackSpeed;
            GameObject instance = GameObject.Instantiate(bullet, transform.position, new Quaternion());
            if (transform.name == "Alien Gun Left")
            {
                instance.GetComponent<Rigidbody>().AddForce(-instance.transform.right * bulletSpeed, ForceMode.Impulse);
                Debug.Log(transform.name);
            }
            else
                instance.GetComponent<Rigidbody>().AddForce(instance.transform.right * bulletSpeed, ForceMode.Impulse);
        }
    }
    
}
