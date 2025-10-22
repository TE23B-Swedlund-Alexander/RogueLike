using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class player_movement : MonoBehaviour
{

    public float speed = 0.5f;
    private Rigidbody2D rb;
    private Vector2 input;
    string sceneName;

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
        if (sceneName == "Main_Game")
        {
            
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        input.Normalize();
        }

    }

    private void FixedUpdate()
    {
        rb.linearVelocity = input * speed;
    }
}
