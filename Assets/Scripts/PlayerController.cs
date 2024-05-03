using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRb2D;
    Animator playerAnimator;
    Vector2 velocity;
    Joystick joystick;
    JoystickController joystickController;

    [SerializeField] float speed;
    [SerializeField] float acceleration;
    [SerializeField] float deceleration;
    [SerializeField] float jumpPower;
    [SerializeField] int jumpLimit;

    int jumpNumb;
    bool jumping;

    // Start is called before the first frame update
    void Start()
    {
        playerRb2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        joystick = FindObjectOfType<Joystick>();
        joystickController = FindObjectOfType<JoystickController>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        KeyBoardControl();
#else 
        JoystickControl();
#endif
    }

    void KeyBoardControl()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        Vector2 scale = transform.localScale;

        if (moveInput > 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, moveInput * speed, acceleration * Time.deltaTime);
            playerAnimator.SetBool("Walk", true);
            scale.x = 0.3f;
        }
        else if (moveInput < 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, moveInput * speed, acceleration * Time.deltaTime);
            playerAnimator.SetBool("Walk", true);
            scale.x = -0.3f;
        }
        else
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, deceleration * Time.deltaTime);
            playerAnimator.SetBool("Walk", false);
        }

        transform.localScale = scale;
        transform.Translate(velocity * Time.deltaTime);

        if (Input.GetKeyDown("space")) { StartTheJump(); }

        if (Input.GetKeyUp("space")) { StopTheJump(); }
    }

    void JoystickControl()
    {
        float moveInput = joystick.Horizontal;
        Vector2 scale = transform.localScale;

        if (moveInput > 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, moveInput * speed, acceleration * Time.deltaTime);
            playerAnimator.SetBool("Walk", true);
            scale.x = 0.3f;
        }
        else if (moveInput < 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, moveInput * speed, acceleration * Time.deltaTime);
            playerAnimator.SetBool("Walk", true);
            scale.x = -0.3f;
        }
        else
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, deceleration * Time.deltaTime);
            playerAnimator.SetBool("Walk", false);
        }

        transform.localScale = scale;
        transform.Translate(velocity * Time.deltaTime);

        if (joystickController.pressTheButton == true && jumping == false)
        {
            jumping = true;
            StartTheJump();
        }
        else if (joystickController.pressTheButton == false && jumping == true)
        {
            jumping = false;
            StopTheJump();
        }
    }

    void StartTheJump()
    {
        if (jumpNumb < jumpLimit)
        {
            playerRb2D.AddForce(new Vector2(0, jumpPower));
            playerAnimator.SetBool("Jump", true);
            FindObjectOfType<SliderControl>().SliderValue(jumpLimit, jumpNumb);
            FindObjectOfType<AudioControl>().JumpVoice();
        }
    }

    void StopTheJump()
    {
        playerAnimator.SetBool("Jump", false);
        jumpNumb++;
        FindObjectOfType<SliderControl>().SliderValue(jumpLimit, jumpNumb);
    }

    public void ResetTheJump()
    {
        jumpNumb = 0;
        FindObjectOfType<SliderControl>().SliderValue(jumpLimit, jumpNumb);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            FindObjectOfType<GameManager>().EndTheGame();
        }
    }

    public void GameOver()
    {
        Destroy(gameObject);
    }
}
