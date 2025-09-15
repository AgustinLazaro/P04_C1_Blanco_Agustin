using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    [SerializeField] private GameObject StartPanel;
    [SerializeField] private Button StartButton;

    private void Awake()
    {
        if (StartButton != null)
        {
            StartButton.onClick.AddListener(OnStartButtonPressed);
        }
        // Al iniciar, el juego está pausado
        if (StartPanel != null)
        {
            StartPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private void OnStartButtonPressed()
    {
        if (StartPanel != null)
        {
            StartPanel.SetActive(false); // Oculta el panel
        }
        Time.timeScale = 1f; // Reanuda el juego
       
    }
}
