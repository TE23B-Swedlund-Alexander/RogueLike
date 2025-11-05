using UnityEngine;

public class nemenymomnt : MonoBehaviour
{


    public float speed = 5f;
    [SerializeField]
    GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 goal = Vector3.Lerp(transform.position, player.transform.position, speed * Time.deltaTime);
        transform.position = goal;
    }
}
