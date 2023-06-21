using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    private CubeProperties cubeProperties;

    public GameData gameData;

    private GameManager gameManager;

    private void Awake() 
    {
        cubeProperties=GetComponent<CubeProperties>();
        gameManager=FindObjectOfType<GameManager>();
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
                EventManager.Broadcast(GameEvent.OnIncreaseScore);
                Destroy(cubeProperties.gameObject);
                Destroy(otherCube.gameObject);
                gameManager.CubeNumbers.Add(gameData.tempRandomNumber);
            }

            else
            {
                Debug.Log("FAIL");
            }
        }
        
    }
}
