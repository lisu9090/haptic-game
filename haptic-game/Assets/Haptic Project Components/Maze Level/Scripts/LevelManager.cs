using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] wolves;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ActivateWolves()
    {
        foreach (var wolf in wolves)
        {
            wolf.GetComponent<Wolf>().killSheep();
        }

    }
}
