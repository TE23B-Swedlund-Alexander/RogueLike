using NUnit.Framework;
using Unity.Mathematics;
using UnityEngine;

public class projectile_expiration_date : MonoBehaviour
{
    public float shelfLife;

    float timer = 0;

    public GameObject Explotion;

    public bool isFireball;

    Transform spawn;

    [SerializeField]
    string guythatcanhurtme;

    [SerializeField]
    float TimeBetweenHurt;

    float TimeSinceHurt;

   public int maxHp = 3;




    void Start()
    {
        spawn = GetComponent<Transform>();
    }


    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= shelfLife)
        {
            if (isFireball == true)
            {
                Instantiate(Explotion, spawn.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
        TimeSinceHurt+=Time.deltaTime;
        

        if (maxHp <= 0)
        {
            Destroy (this.gameObject);
        if (isFireball == true)
            {
                Instantiate(Explotion, spawn.position, Quaternion.identity);
            }
        }

    }
    void TakeDamage(int dmg)
    {
        if (TimeSinceHurt > TimeBetweenHurt)
        {

            maxHp -= dmg;
            TimeSinceHurt = 0;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == guythatcanhurtme)
        {

            timer=shelfLife-0.1f;

        }

    }
}
