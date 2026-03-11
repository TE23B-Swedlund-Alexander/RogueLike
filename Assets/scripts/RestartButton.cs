using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    
   public void ChangeScene()
    {
        SceneManager.LoadScene("Charachter selector");
    }

}
