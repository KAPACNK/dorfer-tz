using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject ball;
    public GameObject unitPrefab;
    public GameObject gameOverPoint;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y < gameOverPoint.transform.position.y)
        {
            GameOver();
        }
    }

    public void RestartScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void SpawnUnuit()
    {
        Instantiate(unitPrefab, new Vector3(ball.transform.position.x, ball.transform.position.y - 40f, ball.transform.position.z - 15f), Quaternion.identity);
        gameOverPoint.transform.position = new Vector3(gameOverPoint.transform.position.x, gameOverPoint.transform.position.y - 60, gameOverPoint.transform.position.z);
    }

    public void GameOver()
    {
        RestartScene();
    }
}
