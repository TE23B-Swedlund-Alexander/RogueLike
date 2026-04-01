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
[SerializeField]
GameObject Projectile;


    public float speed = 0.5f;
    private Rigidbody2D rb;
    private Vector2 input;



    string sceneName;
    public Animator animator;
    private float x;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //hittar rigidbody hoss player
        Scene currentscene = SceneManager.GetActiveScene(); // hittar scenen så att den vet om den får gå eller inte
        sceneName = currentscene.name;
    }




    void Update()
    {

        if (sceneName != "Charachter selector") // om scenen är charachter selector så får player inte gå eftersom att det är charachterselector och inte scenen där man slåss
        {

            input.x = Input.GetAxisRaw("Horizontal"); //massa gå kod som vi lärde oss för ett halvår sen
            input.y = Input.GetAxisRaw("Vertical"); //hämtar x och y från tangenterna och lägger dem i vectorn input
            input.Normalize(); // averagar ut x och y så att man går lika fort diagonalt som rakt



            if (input == Vector2.zero)
            {
                animator.SetBool("walking", false); // gå animation är false om man inte går
            }
            else
            {
                animator.SetBool("walking", true); // om man inte står stilla så går man (kanske behöver ändras för en attacka animation)
            }
            if (input.x > 0)
            {
                Debug.Log("right");
                this.GetComponent<SpriteRenderer>().flipX = true; //flippar gubben när man går åt höger

            }
            if (input.x < 0)
            {
                Debug.Log("left");
                this.GetComponent<SpriteRenderer>().flipX = false; // flippar tillbaka när vänster
            }


            if (transform.position.x < -11)
            {
                Vector3 pos = transform.position;
                pos.x = -11;
                transform.position = pos;
            }
            if (transform.position.y < -5)
            {
                Vector3 pos = transform.position;
                pos.y = -5;
                transform.position = pos;
            }
            if (transform.position.x > 11)
            {
                Vector3 pos = transform.position;
                pos.x = 11;
                transform.position = pos;
            }
            if (transform.position.y > 5)
            {
                Vector3 pos = transform.position;
                pos.y = 5;
                transform.position = pos;
            }



        }


    }
     private void OnMouseUp() {
        
    
    
        if  (sceneName != "Charachter selector")
        {
            Instantiate(Projectile);

        }
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = input * speed; //tror det är den här som säger åt gubben att röra på sig
    }
}
