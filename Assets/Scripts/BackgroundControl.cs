using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    float backgroundPosition;
    float distance = 10.24f;

    // Start is called before the first frame update
    void Start()
    {
        backgroundPosition = transform.position.y;
        FindObjectOfType<Planets>().PlanetPlace(backgroundPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (backgroundPosition + distance < Camera.main.transform.position.y)
        {
            BackgroundPlace();
        }
    }

    void BackgroundPlace()
    {
        backgroundPosition += distance * 2.0f;
        FindObjectOfType<Planets>().PlanetPlace(backgroundPosition);
        Vector2 newPosition = new Vector2(0, backgroundPosition);
        transform.position = newPosition;
    }
}
