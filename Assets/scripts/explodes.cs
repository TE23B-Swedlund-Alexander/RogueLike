using UnityEngine;

public class explodes : MonoBehaviour
{
       float time=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
     
        time = time +Time.deltaTime;
        if (time>0.18f)Destroy(this.gameObject);
    }
}
