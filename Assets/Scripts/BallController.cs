using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    bool finish = true;
    public SceneController sceneController;

    private float FinishTriggerTime;


    // Update is called once per frame
    void Update()
    {
    }

    private void Start()
    {
        FinishTriggerTime  = Time.time;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (FinishTriggerTime + 2f <= Time.time) {
            if (collision.tag == "Finish")
            {
                sceneController.SpawnUnuit();
            }

            FinishTriggerTime = Time.time;
        }
        
    }
}
