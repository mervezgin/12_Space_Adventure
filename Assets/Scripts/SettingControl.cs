using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingControl : MonoBehaviour
{
    [SerializeField] Button easyButton, mediumButton, hardButton;

    // Start is called before the first frame update
    void Start()
    {
        if (Options.EasyValueRead() == 1)
        {
            easyButton.interactable = false;
            mediumButton.interactable = true;
            hardButton.interactable = true;
        }
        if (Options.MediumValueRead() == 1)
        {
            easyButton.interactable = true;
            mediumButton.interactable = false;
            hardButton.interactable = true;
        }
        if (Options.HardValueRead() == 1)
        {
            easyButton.interactable = true;
            mediumButton.interactable = true;
            hardButton.interactable = false;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AlternativeHasChoosen(string level)
    {
        switch (level)
        {
            case "easy":
                Options.EasyValueSend(1);
                Options.MediumValueSend(0);
                Options.HardValueSend(0);
                easyButton.interactable = false;
                mediumButton.interactable = true;
                hardButton.interactable = true;
                break;
            case "medium":
                Options.EasyValueSend(0);
                Options.MediumValueSend(1);
                Options.HardValueSend(0);
                easyButton.interactable = true;
                mediumButton.interactable = false;
                hardButton.interactable = true;
                break;
            case "hard":
                Options.EasyValueSend(0);
                Options.MediumValueSend(0);
                Options.HardValueSend(1);
                easyButton.interactable = true;
                mediumButton.interactable = true;
                hardButton.interactable = false;
                break;
            default:
                break;
        }
    }
}
