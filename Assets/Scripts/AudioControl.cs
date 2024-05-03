using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField] AudioClip jump;
    [SerializeField] AudioClip golden;
    [SerializeField] AudioClip gameOver;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void JumpVoice()
    {
        audioSource.clip = jump;
        audioSource.Play();
    }

    public void GoldenVoice()
    {
        audioSource.clip = golden;
        audioSource.Play();
    }

    public void GameOverVoice()
    {
        audioSource.clip = gameOver;
        audioSource.Play();
    }
}
