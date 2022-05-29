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
    public float costam;
    [SerializeField] private Vector2 scaleX;
    [SerializeField] private Vector2 scaleY;
    [SerializeField] private Vector2 scaleZ;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
