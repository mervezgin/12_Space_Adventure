using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointOnGameScreen : MonoBehaviour
{
    [SerializeField] Text pointText;
    [SerializeField] Text goldenText;

    int point;
    int golden;

    // Start is called before the first frame update
    void Start()
    {
        goldenText.text = " X" + golden;
    }

    // Update is called once per frame
    void Update()
    {
        point = (int)Camera.main.transform.position.y;
        pointText.text = "Point: " + point;
    }

    public void PickGolden()
    {
        golden++;
        goldenText.text = " X" + golden;
    }
}
