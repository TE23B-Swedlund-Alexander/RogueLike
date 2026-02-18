
using UnityEditor.Callbacks;
using UnityEngine;

public class nemenymomnt : MonoBehaviour
{


    public float speed;
    GameObject Player;
    private Vector2 goal;

    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frameTransform>
    void Update()
    {
        Vector3 newPosition = Vector3.MoveTowards(transform.position, Player.transform.position, speed);
// newPosition ligger precis mellan transform.Position och target.transform.Position.

transform.position = newPosition;


       
    }
   
}

