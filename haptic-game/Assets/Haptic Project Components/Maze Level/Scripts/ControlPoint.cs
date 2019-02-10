using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    public Vector3 myRotation;

    // Use this for initialization
    void Start()
    {
        string dir = gameObject.name.Split(' ')[1];
        if (dir == "left") myRotation = new Vector3(0, -90, 0);
        if (dir == "right") myRotation = new Vector3(0, 90, 0);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sheep")
        {
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (gameObject.name.Split(' ')[0] == "Point1")
            {
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionZ;
                GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>().ActivateWolves();
            }
            if (gameObject.name.Split(' ')[0] == "Point2")
            {
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
                GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>().ActivateAliens();
            }
            if (gameObject.name.Split(' ')[0] == "Point3")
            {
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionZ;
            }
            if (gameObject.name.Split(' ')[0] == "Point4")
            {
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX;
            }
            other.gameObject.GetComponent<Sheep>().RotateSheep(myRotation);
        }
    }
}
