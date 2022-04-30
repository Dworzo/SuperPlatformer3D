using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private float coin = 0;

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            Debug.Log("ZebralemMonete");
            coin++;
            textCoins.text = coin.ToString();
            Destroy(other.gameObject);
        }
            
    }
}
