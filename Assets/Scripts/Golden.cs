using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golden : MonoBehaviour
{
    [SerializeField] GameObject golden;

    public void GoldenOpen()
    {
        golden.SetActive(true);
    }

    public void GoldenClose()
    {
        golden.SetActive(false);
    }
}
