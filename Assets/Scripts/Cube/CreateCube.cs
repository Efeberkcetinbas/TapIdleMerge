using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CreateCube : MonoBehaviour
{
    [SerializeField] private CubeProperties cube;

    [SerializeField] private Transform spawnPos;
    [SerializeField] private Transform mergePos;
    public GameData gameData;

    private void OnEnable() 
    {
        EventManager.AddHandler(GameEvent.OnPressedScreen,OnPressedScreen);
        EventManager.AddHandler(GameEvent.OnMergeNumbers,OnMergeNumbers);    
    }

    private void OnDisable() 
    {
        EventManager.RemoveHandler(GameEvent.OnPressedScreen,OnPressedScreen);
        EventManager.RemoveHandler(GameEvent.OnMergeNumbers,OnMergeNumbers);
    }

    private void Start() 
    {
        SpawnCube();
    }

    private void OnPressedScreen()
    {
        SpawnCube();
    }

    private void SpawnCube()
    {
        CubeProperties cloneCube=Instantiate(cube,spawnPos.localPosition,Quaternion.identity);
        cloneCube.Number=gameData.RandomNumber;
        for (int i = 0; i < cloneCube.NumberTexts.Length; i++)
        {
            cloneCube.NumberTexts[i].SetText(gameData.RandomNumber.ToString());
        }
    }

    private void OnMergeNumbers()
    {
        CubeProperties cloneCube=Instantiate(cube,mergePos.localPosition,Quaternion.identity);
        cloneCube.transform.DOMoveY(spawnPos.position.y,0.2f).OnComplete(()=>{
            cloneCube.Number=gameData.tempRandomNumber+1;
            cloneCube.transform.DOScale(Vector3.one*3,0.1f).OnComplete(()=>cloneCube.transform.DOScale(Vector3.one*2,0.1f));
            for (int i = 0; i < cloneCube.NumberTexts.Length; i++)
            {
                cloneCube.NumberTexts[i].SetText((gameData.tempRandomNumber+1).ToString());
            }
        });
        
    }
}
