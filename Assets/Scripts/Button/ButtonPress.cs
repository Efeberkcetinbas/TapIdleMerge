using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonPress : MonoBehaviour
{
    [SerializeField] private float y,oldY,duration;

    [SerializeField] private Transform ButtonGameObject;

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
        ButtonGameObject.DOLocalMoveY(y,duration).OnComplete(()=>{
            ButtonGameObject.DOLocalMoveY(oldY,duration);
        });

        //Particle Goes On

    }
}
