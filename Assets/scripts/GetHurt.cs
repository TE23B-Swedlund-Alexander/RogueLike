using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetHurt : MonoBehaviour
{



    public int maxHp = 3;

    [SerializeField]
    float TimeBetweenHurt;

    float TimeSinceHurt;


    [SerializeField]
    string guythatcanhurtme;

    [SerializeField]
    bool IsPlayer;

    Slider HpSlider;

    public bool isEnemy;

    int Hp=1;
    void Start()
    {
        // if (isEnemy == true)
        // {
        // //  GameObject guy = GameObject.FindGameObjectWithTag("Player");
        // //  guy.GetComponentInChildren<>
        // //  if(guy. == "wizard")
        // //     {
        // //         Hp=1;
        // //     }
        // //  if(guy.name == "knight")
        // //     {
        // //         Hp=4;
        // //     }
        // //  if(guy.name == "archer")
        // //     {
        // //         Hp=3;
        // //     }
        // }


        Hp = maxHp;
        if (IsPlayer == true)
        {
            HpSlider = FindAnyObjectByType<Slider>();
            HpSlider.maxValue = maxHp;
            HpSlider.value = Hp;
        }
    }

    void Update()
    {
        TimeSinceHurt += Time.deltaTime;


        if (Hp <= 0)
        {
            Destroy(this.gameObject);
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

            Hp -= dmg;
            TimeSinceHurt = 0;
            if (IsPlayer)
            {

                HpSlider.value = Hp;
            }
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == guythatcanhurtme)
        {


            TakeDamage(1);

        }

    }
}
