using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{
    private Touch touch;

    private Vector2 touchPosition;

    private Quaternion rotationX, rotationZ;

    private float tiltSpeedModifier = 20f;

    public SceneController sceneController;

    public GameObject ball;



    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.y != 0f) {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0f, transform.eulerAngles.z);
        }

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.RotateAround(ball.transform.position, new Vector3(touch.deltaPosition.x * 1f, 0, 0), tiltSpeedModifier * Time.deltaTime);
                transform.RotateAround(ball.transform.position, new Vector3(0, 0, touch.deltaPosition.y * 1f), tiltSpeedModifier * Time.deltaTime);
            }
        }

    }
}
