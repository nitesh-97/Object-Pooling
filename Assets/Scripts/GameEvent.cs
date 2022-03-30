using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public static GameEvent current;
    private void Awake()
    {
        current = this;
    }

    public event Action<int> onButtonClick;
    public void ButtonClick(int ID)
    {
        if (onButtonClick != null)
        {
            onButtonClick(ID);
        }
    }
   
}
