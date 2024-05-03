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
    int maxPoint;
    int golden;
    int maxGolden;
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
        FindObjectOfType<AudioControl>().GoldenVoice();
    }

    public void GameOver()
    {
        pickPoint = false;
        gameOverPointText.text = "Point: " + point;
        gameOverGoldenText.text = " X" + golden;

        if (Options.EasyValueRead() == 1)
        {
            maxPoint = Options.EasyPointValueRead();
            maxGolden = Options.EasyGoldenValueRead();

            if (point > maxPoint)
            {
                Options.EasyPointValueSend(point);
            }
            if (golden > maxGolden)
            {
                Options.EasyGoldenValueSend(golden);
            }
        }

        if (Options.MediumValueRead() == 1)
        {
            maxPoint = Options.MediumPointValueRead();
            maxGolden = Options.MediumGoldenValueRead();

            if (point > maxPoint)
            {
                Options.MediumPointValueSend(point);
            }
            if (golden > maxGolden)
            {
                Options.MediumGoldenValueSend(golden);
            }
        }

        if (Options.HardValueRead() == 1)
        {
            maxPoint = Options.HardPointValueRead();
            maxGolden = Options.HardGoldenValueRead();

            if (point > maxPoint)
            {
                Options.HardPointValueSend(point);
            }
            if (golden > maxGolden)
            {
                Options.HardGoldenValueSend(golden);
            }
        }
    }
}
