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
    

   
    public void OnClick(int i)
    {
        if (i > 30) { return; }
        //if (t > 1)
        //{
        //    Temp.SetActive(false);
        //    t = 1;
        //}
        if (i <= 10)
        {
            n = i - 1;
            Temp = Objects[n];
           // Debug.Log("Obj no" + n);
        }
        else
        {
            n = i % 10;
            Temp = Objects[n];
        }
        ObjectRender = Temp.GetComponent<Renderer>();
        ObjectRender.sharedMaterial.mainTexture = Texturelist[i-1];
        Debug.Log("Texture" + (i-1));
        Instantiate(Temp, TargetPosition.transform.position, Quaternion.identity);
        t++;
        GameEvent.current.ButtonClick(n);
    }
    
    
}
