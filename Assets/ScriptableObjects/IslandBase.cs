using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestScriptableObject", menuName = "ScriptableObjects/IslandBaseSO")]
public class IslandBase : ScriptableObject
{
  public GameObject islandPrefab;
  public int scaleMin;
  public  int scaleMax;
    [Range(1.0f, 10.0f)]
    public float scaleX;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
