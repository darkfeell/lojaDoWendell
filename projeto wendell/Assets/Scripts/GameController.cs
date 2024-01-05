using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI scorePoints;

    public static GameController instance;
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(points >= 10)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void updateScore()
    {
        points += 1;
        scorePoints.text = points.ToString();
    }
}
