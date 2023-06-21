using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomNumber : MonoBehaviour
{

    [SerializeField] private TextMeshPro randomNumberText;

    [SerializeField] private GameManager gameManager;

    public GameData gameData;

    //Update'e cek
    private void Start() 
    {
        InvokeRepeating("GetRandomNumber",1,1);
    }

    


    private void GetRandomNumber()
    {
        gameData.RandomNumber=Random.Range(1,gameManager.CubeNumbers.Count+1);
        randomNumberText.SetText(gameData.RandomNumber.ToString());
    }
}
