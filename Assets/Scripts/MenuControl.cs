using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField] Sprite[] musicIcons;
    [SerializeField] Button musicButton;

    bool musicOpen = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTheGame()
    {
        SceneManager.LoadScene("SpaceAdventure");
    }

    public void MaxPoint()
    {
        SceneManager.LoadScene("Point");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Music()
    {
        if (musicOpen)
        {
            musicOpen = false;
            musicButton.image.sprite = musicIcons[0];
        }
        else
        {
            musicOpen = true;
            musicButton.image.sprite = musicIcons[1];
        }
    }
}
