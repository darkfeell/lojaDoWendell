using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
        
    }

    public void updateScore()
    {
        points += 1;
        scorePoints.text = points.ToString();
    }
}
