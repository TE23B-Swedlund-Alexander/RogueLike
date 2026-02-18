using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float spawnDelay;
    [SerializeField]
    GameObject nemerentre;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnDelay=10;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnDelay <= 0)
        {

            Instantiate(nemerentre);
            spawnDelay = 5;
        }
        spawnDelay -= Time.deltaTime;
    }
}
