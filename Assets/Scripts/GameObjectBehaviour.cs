using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectBehaviour : MonoBehaviour
{
    [SerializeField] private int ID;
    int TimesAppear = 1;

    // Subscribe to the button click event
    void Start()
    {
        GameEvent.current.onButtonClick += OnObjectAppear;
       
    }

   //When ever the button is clicked ,this method is executed
   //Destroy object only when a different button is pressed
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
        }

    }

    // Unsubscribe to the button click event before getting destroyed
    public void OnDestroy()
    {
        GameEvent.current.onButtonClick -= OnObjectAppear;
    }

    // Destroy used object when same button is pressed repeatedly
    public void Update()
    {
        if (TimesAppear > 1 && gameObject != null)
        {
            Destroy(gameObject);
           
        }
    }

}
