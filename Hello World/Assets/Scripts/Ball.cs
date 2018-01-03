using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Paddle paddle;
    private float volume = 0.3f;
    private bool hasStarted = false;
    private Vector3 ballToPaddleVector;
    public AudioClip pew;

    // Use this for initialization
    void Start()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
        ballToPaddleVector = this.transform.position - paddle.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + ballToPaddleVector;
            if (Input.GetMouseButtonDown(0))
            {
                print("mouse clicked");
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
                hasStarted = true;

            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted) {
            AudioSource.PlayClipAtPoint(pew, transform.position, volume);
        }
    }
}
