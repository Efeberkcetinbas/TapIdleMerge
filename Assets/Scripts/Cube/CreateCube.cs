using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreateCube : MonoBehaviour
{
    [SerializeField] private CubeProperties cube;

    [SerializeField] private Transform spawnPos;
    public GameData gameData;

    private void OnEnable() 
    {
        EventManager.AddHandler(GameEvent.OnPressedScreen,OnPressedScreen);    
    }

    private void OnDisable() 
    {
        EventManager.RemoveHandler(GameEvent.OnPressedScreen,OnPressedScreen);
    }

    private void OnPressedScreen()
    {
        CubeProperties cloneCube=Instantiate(cube,spawnPos.localPosition,Quaternion.identity);
        cloneCube.Number=gameData.RandomNumber;
        for (int i = 0; i < cloneCube.NumberTexts.Length; i++)
        {
            cloneCube.NumberTexts[i].SetText(gameData.RandomNumber.ToString());
        }
    }

    private void OnCreateMergeCube()
    {

    }
}
