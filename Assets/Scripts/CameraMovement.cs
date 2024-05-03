using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    float speed;
    float acceleration = 0.03f;
    float maxSpeed = 0.8f;
    bool movement = true;

    // Start is called before the first frame update
    void Start()
    {
        if (Options.EasyValueRead() == 1)
        {
            speed = 0.3f; acceleration = 0.03f; maxSpeed = 1.5f;
        }
        if (Options.MediumValueRead() == 1)
        {
            speed = 0.5f; acceleration = 0.05f; maxSpeed = 2.0f;
        }
        if (Options.HardValueRead() ==1)
        {
            speed = 0.8f; acceleration = 0.08f; maxSpeed = 2.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (movement)
        {
            MoveTheCamera();
        }
    }

    void MoveTheCamera()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        speed += acceleration * Time.deltaTime;
        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }
    }
}
