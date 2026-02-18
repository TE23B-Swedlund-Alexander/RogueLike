using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Tilemaps;
using Unity.VisualScripting;
using System;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 0.5f;
    private Rigidbody2D rb;
    private Vector2 input;

    
    
    string sceneName;
    public Animator animator;
    private float x;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Scene currentscene = SceneManager.GetActiveScene();
       sceneName = currentscene.name;
    }
 		    


    // Update is called once per frame
    void Update()
    {
    
        if (sceneName != "Charachter selector")
        {
            
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        input.Normalize();
        


        if (input == Vector2.zero)
            {
                  animator.SetBool("walking",false);
            }
            else{
animator.SetBool("walking",true);
            }
    if (input.x>0)
            {
                Debug.Log("right");
            this.GetComponent<SpriteRenderer>().flipX=true;
            
            }
    if (input.x<0)
            {
                Debug.Log("left");
            this.GetComponent<SpriteRenderer>().flipX=false;
            }
            
                

               
                
            
             }
            
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = input * speed;
    }
}
