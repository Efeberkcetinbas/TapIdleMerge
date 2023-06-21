using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouch : MonoBehaviour
{
    private Touch touch;

    private void Update() 
    {
        TouchControl();
    }
    private void TouchControl()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                EventManager.Broadcast(GameEvent.OnPressedScreen);
            }
            if (touch.phase == TouchPhase.Moved)
            {
                //Nothing Goes Here For Now...
            }
            if (touch.phase == TouchPhase.Ended)
            {
                //Nothing Goes Here For Now...
            }
        }
    }
}
