using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandom : MonoBehaviour
{
    public List<GameObject> liGoSpawn = new List<GameObject>();
    CoinPicker coinPicker;
    

    void Awake()
    {
       
    }
    void Start()
    {
        GameObject goToSpawn = liGoSpawn[Random.Range(0, liGoSpawn.Count)];
        Instantiate(goToSpawn, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void Update()
    {
   
    }


}
