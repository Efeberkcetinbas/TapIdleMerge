using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    private CubeProperties cubeProperties;

    public GameData gameData;

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
                gameData.tempRandomNumber=gameData.RandomNumber;
                EventManager.Broadcast(GameEvent.OnMergeNumbers);
                Destroy(cubeProperties.gameObject);
                Destroy(otherCube.gameObject);
            }

            else
            {
                Debug.Log("FAIL");
            }
        }
        
    }
}
