using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointOnGameScreen : MonoBehaviour
{
    [SerializeField] Text pointText;

    int point;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        point = (int)Camera.main.transform.position.y;
        pointText.text = "Point: " + point;
    }
}
