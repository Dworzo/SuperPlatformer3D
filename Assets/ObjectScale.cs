using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScale : MonoBehaviour
{
    public float scaleSpeed = 5f;
    Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (temp.x>0.1)
        {
            temp = transform.localScale;
            temp.x += Time.deltaTime * -1;
            temp.z += Time.deltaTime * -1;
            transform.localScale = temp;
        }
        else
        {
            //rosne
            Debug.Log("Rosne");
            temp = transform.localScale;
            temp.x += Time.deltaTime;
            temp.z += Time.deltaTime;
            transform.localScale = temp;
        }
    }
}
