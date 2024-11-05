using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathChecker : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float deathThreshold = -5f;

    private void Update()
    {
        if (player.position.y < mainCamera.transform.position.y + deathThreshold)
        {
            SceneManager.LoadScene("Defeat");
        }
    }
}
