using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    PolygonCollider2D polygonCollider2D;

    float randomSpeed;
    bool move = true;
    float min, max;

    public bool Move { get { return move; } set {move = value; } }

    // Start is called before the first frame update
    void Start()
    {
        if (Options.EasyValueRead() ==1) { randomSpeed = Random.Range(0.2f, 0.6f); }
        if (Options.MediumValueRead() == 1) { randomSpeed = Random.Range(0.5f, 0.9f); }
        if (Options.HardValueRead() == 1) { randomSpeed = Random.Range(0.8f, 1.2f); }

        polygonCollider2D = GetComponent<PolygonCollider2D>();

        float objectWidth = polygonCollider2D.bounds.size.x / 2;

        if (transform.position.x > 0)
        {
            min = objectWidth;
            max = ScreenCalculator.instance.Width - objectWidth;
        }
        else
        {
            min = -ScreenCalculator.instance.Width + objectWidth;
            max = -objectWidth;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            float pingPongX = Mathf.PingPong(Time.time * randomSpeed, max - min) + min;
            Vector2 pingPong = new Vector2(pingPongX, transform.position.y);
            transform.position = pingPong;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Feet")
        {
            GameObject.FindGameObjectWithTag("Player").transform.parent = transform;
            GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerController>().ResetTheJump();
        }
    }
}
