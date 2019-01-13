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
            other.gameObject.GetComponent<Sheep>().RotateSheep(myRotation);
            GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>().ActivateWolves();
        }
    }
}
