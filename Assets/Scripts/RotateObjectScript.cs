using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectScript : MonoBehaviour
{
    Vector3 movement;
    void Start()
    {
        movement = new Vector3(0, 90f, 0);    
    }

    void Update()
    {
        transform.Rotate(0, 90f * Time.deltaTime, 0, Space.World);
    }
}
