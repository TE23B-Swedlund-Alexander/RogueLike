using NUnit.Framework;
using Unity.Mathematics;
using UnityEngine;

public class projectile_expiration_date : MonoBehaviour
{
public float shelfLife;
float timer=0;
public GameObject Explotion;
public bool isFireball;
Transform spawn;
    void Start()
    {
        spawn = GetComponent<Transform>();
    }

   
    void Update()
    {
        
     timer+=Time.deltaTime;
        if (timer >= shelfLife)
        {
            if (isFireball == true)
            {
                Instantiate(Explotion,spawn.position,Quaternion.identity);
            }
            Destroy(this.gameObject);
        }

    }
}
