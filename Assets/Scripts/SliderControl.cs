using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 1.0f;
    }

    public void SliderValue(int maxValue, int currentValue)
    {
        int sliderValue = maxValue - currentValue;
        slider.maxValue = maxValue;
        slider.value = sliderValue;
    }
}
