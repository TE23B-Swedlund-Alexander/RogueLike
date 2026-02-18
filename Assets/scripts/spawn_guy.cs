using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class spawn_guy : MonoBehaviour
{
    [SerializeField]
    GameObject wizard;
    [SerializeField]
    GameObject archer;
    [SerializeField]
    GameObject knight;
    [SerializeField]
    Color wizardPulple;
    [SerializeField]
    Color knightRed;
    [SerializeField]
    Color rangerGreen;

    int GuyChosen = 0;
    string sceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);


    }

    // Update is called once per frame
    void Update()
    {
        Scene currentscene = SceneManager.GetActiveScene();
        sceneName = currentscene.name;
        if (sceneName == "Main_Game")
        {
            if (GuyChosen == 1)
            {
                Instantiate(wizard);
                Destroy(this.gameObject);
                
                Camera.main.backgroundColor = wizardPulple;

            }
            if (GuyChosen == 2)
            {
                Instantiate(archer);
                Destroy(this.gameObject);

                Camera.main.backgroundColor = rangerGreen;
            }
            if (GuyChosen == 3)
            {
                Instantiate(knight);
                Destroy(this.gameObject);

                Camera.main.backgroundColor = knightRed;

            }
        }
    }

    public void Wizard()
    {
        GuyChosen = 1;
    }
    public void Archer()
    {
        GuyChosen = 2;
    }
    public void Knight()
    {
        GuyChosen = 3;
    }
}
