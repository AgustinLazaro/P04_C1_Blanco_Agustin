using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Necesario para usar Button

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private Button restartButton;
    private void Start()
    {
        // Asigna el evento al botón desde código
        if (restartButton != null)
        {
            restartButton.onClick.AddListener(Restart);
        }
    }

    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            GameOverPanel.SetActive(true);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
