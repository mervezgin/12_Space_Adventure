using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField] Sprite[] musicIcons;
    [SerializeField] Button musicButton;

    //bool musicOpen = true;

    // Start is called before the first frame update
    void Start()
    {
        if (Options.IsTheRecord()==false) { Options.EasyValueSend(1); }
        if (Options.MusicOpenIsThereRecord() == false) { Options.MusicOpenSend(1); }
        MusicSettingsCheck();
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
        if (Options.MusicOpenRead() == 1)
        {
            Options.MusicOpenSend(0);
            MusicControl.instance.PlayMusic(false);
            musicButton.image.sprite = musicIcons[0];
        }
        else
        {
            Options.MusicOpenSend(1);
            MusicControl.instance.PlayMusic(true);
            musicButton.image.sprite = musicIcons[1];
        }
    }

    void MusicSettingsCheck()
    {
        if (Options.MusicOpenRead() == 1)
        {
            musicButton.image.sprite = musicIcons[1];
            MusicControl.instance.PlayMusic(true);
        }
        else
        {
            musicButton.image.sprite = musicIcons[0];
            MusicControl.instance.PlayMusic(false);
        }
    }
}
