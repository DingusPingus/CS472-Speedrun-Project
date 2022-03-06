
using UnityEngine;

//this class handles shooting of rays so that we can hit targets
//it is largely based upon this tutorial: https://www.youtube.com/watch?v=THnivyG0Mvo
public class Gun : MonoBehaviour
{
  
    public Camera cam;
    public float range = 100f;
    // Update is called once per frame
    void Start(){
 
    }
    void Update()
    {
        if( Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }


    void Shoot(){
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range)){
            //Debug.Log(hit.transform.name);
            
            Target target = hit.transform.GetComponent<Target>();

            //if not null then we have hit a target and therefore target must be destroyed
            if(target!= null){
                
                target.Die();
            }
        }
    }
}
