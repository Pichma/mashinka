using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject car;
    void Start()
    {

    }
    void LateUpdate()
    {
        transform.position = car.transform.position + new Vector3(-20,34,0);
    }
}