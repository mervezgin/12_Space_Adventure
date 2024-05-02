using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnTheScreen : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -ScreenCalculator.instance.Width)
        {
            Vector2 temp = transform.position;
            temp.x = -ScreenCalculator.instance.Width;
            transform.position = temp;
        }
        if (transform.position.x > ScreenCalculator.instance.Width)
        {
            Vector2 temp = transform.position;
            temp.x = ScreenCalculator.instance.Width;
            transform.position = temp;
        }
    }
}
