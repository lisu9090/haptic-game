using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    public Rigidbody sheepRigidbody;
    public float sheepSpeed;

    // Use this for initialization
    void Start()
    {
        sheepRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 myPosition = transform.position;
        sheepRigidbody.MovePosition(myPosition + transform.forward * sheepSpeed * Time.fixedDeltaTime);
    }

    public void RotateSheep(Vector3 rotation)
    {
        transform.Rotate(rotation);
    }
}
