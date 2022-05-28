using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrowingFlower : MonoBehaviour
{
    private float coin = 0;
    public Collider flowerCollider;
    public TextMeshProUGUI textCoins;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("ZebralemMonete");
            coin++;
            textCoins.text = coin.ToString();
            //Destroy(other.gameObject);
            transform.localScale = new Vector3(4, 4, 4);
            flowerCollider.enabled = !flowerCollider.enabled;

        }
            
    }
}
