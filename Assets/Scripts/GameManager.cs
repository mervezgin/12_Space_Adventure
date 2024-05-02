using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject joystick;
    [SerializeField] GameObject jumpButton;
    [SerializeField] GameObject sign;
    [SerializeField] GameObject menuButton;
    [SerializeField] GameObject slider;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        UIOpen();
    }

    void UIOpen()
    {
        joystick.SetActive(true);
        jumpButton.SetActive(true);
        sign.SetActive(true);
        menuButton.SetActive(true);
        slider.SetActive(true);
    }

    void UIClose()
    {
        joystick.SetActive(false);
        jumpButton.SetActive(false);
        sign.SetActive(false);
        menuButton.SetActive(false);
        slider.SetActive(false);
    }

    public void EndTheGame()
    {
        gameOverPanel.SetActive(true);
        FindObjectOfType<PointOnGameScreen>().GameOver();
        UIClose();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SpaceAdventure");
    }
}
