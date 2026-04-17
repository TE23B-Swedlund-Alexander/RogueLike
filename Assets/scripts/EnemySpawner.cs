using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

   public float spawnDelay;
    [SerializeField]
    GameObject enemy;
    Transform spawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        spawn = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnDelay <= 0)
        {
    

           Instantiate(enemy, spawn.position, Quaternion.identity);
           
            spawnDelay = 5;
        }
        spawnDelay -= Time.deltaTime;
    }
}
