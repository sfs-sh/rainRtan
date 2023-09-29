using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    public static GameManager I;
    public Text scoreText;
    int totalScore = 0;

    void Awake()
    {
        I = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void makeRain()
    {
        Instantiate(rain);
    }

    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }

}
