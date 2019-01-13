using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgePart : MonoBehaviour {
    public Transform objectToMove;
    public bool keep = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            if(hit.transform.gameObject.tag == "Touchable" && keep)
            objectToMove.transform.position = hit.point;
        }

        if (Input.GetMouseButtonDown(0))
        {
            keep = !keep;
        }
    }
}
