using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrowingFlower : MonoBehaviour
{
    
    public Collider flowerCollider;
    

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("ZebralemMonete");
            
          
            //Destroy(other.gameObject);
            transform.localScale = new Vector3(4, 4, 4);
            flowerCollider.enabled = !flowerCollider.enabled;

        }
            
    }
}
