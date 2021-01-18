using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public GameObject scoreText;
    public int score = 0;

    void Start()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
