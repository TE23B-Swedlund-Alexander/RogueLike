using UnityEngine;

public class explodes : MonoBehaviour
{
       
    //en explotion som skapas av fireball
    void Start()
    {
       
    }

    
    void Update()
    {
     
        
        Destroy(this.gameObject,0.18f);
    }
}
