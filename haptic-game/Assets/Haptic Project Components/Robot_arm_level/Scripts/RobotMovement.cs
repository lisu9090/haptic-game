using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMovement : MonoBehaviour {
    public float rotationSpeed = 1;
    public float movementSpeed = 1;
    public GameObject cam;
    private float speedUp = 0;
    private float movementDirection = 0;
	// Use this for initialization
	void Start () {
		//if(cam == null
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            if (movementDirection < 0)
                speedUp -= (movementSpeed/15);
            else
            {
                movementDirection = 1;
                if(speedUp < movementSpeed)
                    speedUp += (movementSpeed / 30);
            }
            moveRobot();
        }
        if(Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.UpArrow))
        {
            if (movementDirection > 0)
                speedUp -= (movementSpeed / 15);
            else
            {
                movementDirection = -1;
                if (speedUp < movementSpeed)
                    speedUp += (movementSpeed / 30);
            }
            moveRobot();
        }
        if ((!(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow)) || (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow))) && speedUp > 0)
        {
            speedUp -= (movementSpeed / 30);
            moveRobot();
        }

        if (speedUp <= 0)
        {
            if(movementDirection != 0)
                movementDirection = 0;
            if(speedUp < 0)
                speedUp = 0;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0, -rotationSpeed, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, rotationSpeed, 0));
        }
    }

    private void moveRobot()
    {
        Vector3 position = cam.transform.position;
        position.y = 0;
        if (movementDirection > 0)
        {
            position.x = (this.transform.position.x - position.x);
            position.z = (this.transform.position.z - position.z);
        }
        else if (movementDirection < 0)
        {
            position.x -= this.transform.position.x;
            position.z -= this.transform.position.z;
        }
        position = position.normalized;
        position.Scale(new Vector3(speedUp, 0, speedUp));
        this.transform.position += position;
    }
}