using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn_guy : MonoBehaviour
{
    [SerializeField]
    GameObject wizard;
    [SerializeField]
    GameObject archer;
    [SerializeField]
    GameObject knight;

    int GuyChosen = 0;
    string sceneName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
          Scene currentscene = SceneManager.GetActiveScene();
        sceneName = currentscene.name;
       
    }

    // Update is called once per frame
    void Update()
    {
if (sceneName == "Main_Game")
        {
            if (GuyChosen == 1)
            {
                Instantiate(wizard);
                Destroy(this.gameObject);
            }
            if (GuyChosen == 2)
            {
                Instantiate(archer);
                Destroy(this.gameObject);
            }
            if (GuyChosen == 3)
            {
                Instantiate(knight);
                Destroy(this.gameObject);
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
