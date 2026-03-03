using UnityEngine;

public class GetHurt : MonoBehaviour
{
    [SerializeField]
    int Hp = 3;

    [SerializeField]
    float TimeBetweenHurt;

    float TimeSinceHurt;

 
    void Update()
    {
        TimeSinceHurt+=Time.deltaTime;

        if (Hp <= 0)
        {
            Destroy (this.gameObject);
        }
    }


    void TakeDamage(int dmg)
    {
        if (TimeSinceHurt > TimeBetweenHurt)
        {
            
        Hp-=dmg;
        }
    }
}
