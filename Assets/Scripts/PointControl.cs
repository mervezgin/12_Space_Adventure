using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointControl : MonoBehaviour
{
    [SerializeField] Text easyPoint, easyGolden, mediumPoint, mediumGolden, hardPoint, hardGolden;

    // Start is called before the first frame update
    void Start()
    {
        easyPoint.text = "Point: " + Options.EasyPointValueRead();
        easyGolden.text = " X" + Options.EasyGoldenValueRead();

        mediumPoint.text = "Point: " + Options.MediumPointValueRead();
        mediumGolden.text = " X" + Options.MediumGoldenValueRead();

        hardPoint.text = "Point: " + Options.HardPointValueRead();
        hardGolden.text = " X" + Options.HardGoldenValueRead();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
