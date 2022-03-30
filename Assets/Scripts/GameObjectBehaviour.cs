using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectBehaviour : MonoBehaviour
{
    [SerializeField] private int ID;
    int TimesAppear = 1;
    // Add new Events
    void Start()
    {
        GameEvent.current.onButtonClick += OnObjectAppear;
        Debug.Log("G" + ID);
        //GameEvent.current.onDoorTriggerExit += OnDoorExit;
    }

    //Opens the door when player is near
    public void OnObjectAppear(int ID)
    {
        if (ID != this.ID && this != null)
        {
            
            if (gameObject == null) { return; }
            gameObject.SetActive(false);
            TimesAppear += 1;
            Destroy(gameObject);
        }
        else
        {
            TimesAppear += 1;
            if (gameObject == null) { return; }
           
            //gameObject.SetActive(true);
        }

    }
    public void OnDestroy()
    {
        GameEvent.current.onButtonClick -= OnObjectAppear;
    }
    public void Update()
    {
        if (TimesAppear > 1 && gameObject != null)
        {
            Destroy(gameObject);
            //return;
        }
    }

}
