using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}
