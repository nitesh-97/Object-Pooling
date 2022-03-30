using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSelection : MonoBehaviour
{
    public GameObject[] Objects;
    public Texture [] Texturelist;
    private Renderer ObjectRender;
    public Transform TargetPosition;
    int t = 1;
    int n;
    GameObject Temp;

    //Each button executes this 
    public void OnClick(int i)
    {
        // Invalid input won't create an error
        if (i > 30) { return; }

        //To reuse 10 GameObjects for 30 textures
        if (i <= 10)
        {
            n = i - 1;
            Temp = Objects[n];
        }
        else
        {
            n = i % 10;
            Temp = Objects[n];
        }
        // Assign new texture to the material of specific gameobject
        ObjectRender = Temp.GetComponent<Renderer>();
        ObjectRender.sharedMaterial.mainTexture = Texturelist[i-1];
        
        //Produce a clone of the modified gameoject at its original location
        Instantiate(Temp);
        t++;
        GameEvent.current.ButtonClick(n);
    }
    
    
}
