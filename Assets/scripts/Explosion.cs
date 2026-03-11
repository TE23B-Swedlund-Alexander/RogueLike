using UnityEngine;

public class explodes : MonoBehaviour
{
       float time=0;
    //en explotion som skapas av fireball
    void Start()
    {
       
    }

    
    void Update()
    {
     
        time = time +Time.deltaTime;
        if (time>0.18f)Destroy(this.gameObject);
    }
}
