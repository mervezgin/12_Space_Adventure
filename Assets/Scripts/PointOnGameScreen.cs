using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointOnGameScreen : MonoBehaviour
{
    [SerializeField] Text pointText;
    [SerializeField] Text goldenText;
    [SerializeField] Text gameOverPointText;
    [SerializeField] Text gameOverGoldenText;

    int point;
    int golden;
    bool pickPoint = true;

    // Start is called before the first frame update
    void Start()
    {
        goldenText.text = " X" + golden;
    }

    // Update is called once per frame
    void Update()
    {
        if (pickPoint)
        {
            point = (int)Camera.main.transform.position.y;
            pointText.text = "Point: " + point;
        }
    }

    public void PickGolden()
    {
        golden++;
        goldenText.text = " X" + golden;
    }

    public void GameOver()
    {
        pickPoint = false;
        gameOverPointText.text = "Point: " + point;
        gameOverGoldenText.text = " X" + golden;
    }
}
