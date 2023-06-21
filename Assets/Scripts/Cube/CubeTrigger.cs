using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    private CubeProperties cubeProperties;

    private void Awake() 
    {
        cubeProperties=GetComponent<CubeProperties>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        CubeProperties otherCube=other.gameObject.GetComponent<CubeProperties>();


        if(otherCube!=null && cubeProperties.CubeID > otherCube.CubeID)
        {
            if(cubeProperties.Number==otherCube.Number)
            {
                Debug.Log("HIT : " + cubeProperties.Number);
            }
        }
        
    }
}