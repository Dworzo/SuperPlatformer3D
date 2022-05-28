using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinPicker : MonoBehaviour
{
    public static float coin = 0;
    
    public TextMeshProUGUI textCoins;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            Debug.Log("ZebralemMonete");
            coin++;
            textCoins.text = coin.ToString();
           
            //Destroy(other.gameObject);
           
        }
     

    }
}
