using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPlatform : MonoBehaviour
{
    public GameObject field;
    private Material fieldMatieral;
    
    // Start is called before the first frame update
    void Start()
    {
        
        fieldMatieral = field.GetComponentInChildren<MeshRenderer>().sharedMaterial;;
        fieldMatieral.SetColor("_Color", Color.red);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.isLevelEnd()){
            fieldMatieral.SetColor("_Color", Color.white);
        }
    }

    //this is so ending platforms in different scenes do not affect each other
    void OnDestroy(){
        fieldMatieral = field.GetComponentInChildren<MeshRenderer>().sharedMaterial;;
        fieldMatieral.SetColor("_Color", Color.red);
    }
}
