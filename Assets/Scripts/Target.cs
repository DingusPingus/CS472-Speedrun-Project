
using UnityEngine;

//This script destroys the target
//this class is partly based upon this tutorial: https://www.youtube.com/watch?v=THnivyG0Mvo
public class Target : MonoBehaviour
{
    public GameObject center;
    // Update is called once per frame
    void Update()
    {
        
    }

    //we make this public so our Gun class can destroy this target when it is hit with a ray    
    public void Die(){
        Destroy(gameObject);
    }
   
}
