using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour {
    private bool runForSheep;
    public Rigidbody wolfRigidbody;
    public float wolfSpeed;

	// Use this for initialization
	void Start () {
        runForSheep = false;
        wolfRigidbody = GetComponent<Rigidbody>();
        wolfSpeed = 70;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (runForSheep)
        {
            Vector3 myPosition = transform.position;
            wolfRigidbody.MovePosition(myPosition + transform.forward * wolfSpeed * Time.fixedDeltaTime);
        }
    }

    public void killSheep()
    {
        runForSheep = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Sheep")
        {
            Debug.Log("Game over!");
        }
    }
}
