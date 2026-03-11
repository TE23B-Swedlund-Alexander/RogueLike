using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetHurt : MonoBehaviour
{
    [SerializeField]
Slider HpSlider;


    [SerializeField]
    int maxHp = 3;

    [SerializeField]
    float TimeBetweenHurt;

    float TimeSinceHurt;

    
      [SerializeField]
      string guythatcanhurtme;

[SerializeField]
bool IsPlayer;

int Hp;
    void Start()
    {
        Hp = maxHp;
    HpSlider.maxValue = maxHp;
    HpSlider.value = Hp;
    }

    void Update()
    {
        TimeSinceHurt+=Time.deltaTime;
        

        if (Hp <= 0)
        {
            Destroy (this.gameObject);
            if (IsPlayer == true)
            {
                SceneManager.LoadScene("Game_Over");
            }
        }
    }


    void TakeDamage(int dmg)
    {
        if (TimeSinceHurt > TimeBetweenHurt)
        {
            
        Hp-=dmg;
        TimeSinceHurt=0;
        HpSlider.value=Hp;
        }
    }
      

void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.gameObject.tag == guythatcanhurtme)
        {
            
            
            
            int dmg = 1;
            TakeDamage(dmg);
          
        }

    }
}
