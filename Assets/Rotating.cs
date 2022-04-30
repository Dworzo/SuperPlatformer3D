using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    public float turnSpeed = 5;

    void Update()
    {
        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);
    }
}
