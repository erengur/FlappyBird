using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public Text scoreText;
    public int score;
    void Start()
    {
        score=0; 
        scoreText.text = score.ToString();
    }
    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
