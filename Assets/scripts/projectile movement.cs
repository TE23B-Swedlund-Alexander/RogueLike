using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class projectilemovement : MonoBehaviour 
//blev en mixup i namnen men det här borde heta FireProjectile igentligen
{


// använde en tutorial för det här scriptet https://www.youtube.com/watch?v=-bkmPm_Besk 

    private Camera mainCam;

    private Vector3 mousePos;

    public GameObject bullet;
    public Transform bulletTransform;

    public bool canFire;
    private float timer;

public float timeBetweenFire;


    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

    }




    void Update()
    {

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
        if (canFire == false)
        {
            timer+=Time.deltaTime;
            if (timer > timeBetweenFire)
            {
                timer=0;
                canFire=true;

            }
        }

        if (Input.GetMouseButton(0)&& canFire)
        {
            canFire= false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }


    }


}
