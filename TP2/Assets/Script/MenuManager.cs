using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNameInput;

    public void StartGame()
    {
        if (playerNameInput != null)
        {
            string playerName = playerNameInput.text;

            if (string.IsNullOrEmpty(playerName))
            {
                Debug.LogError("Le nom du joueur ne peut pas être vide !");
                return; 
            }

            PlayerPrefs.SetString("PlayerName", playerName);
            PlayerPrefs.Save();
            SceneManager.LoadScene("LevelEasy");
        }
        else
        {
            Debug.LogError("Le champ de saisie du nom du joueur n'est pas assigné !");
        }
    }
}
