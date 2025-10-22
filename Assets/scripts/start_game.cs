using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("Main_Game");
   } 

}
