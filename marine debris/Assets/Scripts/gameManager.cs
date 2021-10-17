using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject debris;
    public GameObject Star;
    public GameObject PlayerController;
    public GameObject gameOverTxt;
    public GameObject Player;

    public static gameManager I;
    public Animator anim;

    public Text timeTxt;
    public Text scoreTxt;
    public Text bestTimeTxt;
    public Text bestScoreTxt;

    int totalScore = 0;
    float alive = 0.0f;

    private float savedAlive = 0.0f;
    private int savedScore = 0;

    void Awake()
    {
        I = this;
        savedAlive = PlayerPrefs.GetFloat("High", 0);
        bestTimeTxt.text = savedAlive.ToString("N1");
        savedScore = PlayerPrefs.GetInt("HighScore", 0);
        bestScoreTxt.text = savedScore.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeDebris", 0.0f, 1.0f);
        InvokeRepeating("makeStar", 0.0f, 5.0f);
    }

    void makeDebris()
    {
        Instantiate(debris);
    }
    void makeStar()
    {
        Instantiate(Star);
    }
    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        timeTxt.text = alive.ToString("N1");
        if(alive > savedAlive)
        {
            savedAlive = alive ;
            PlayerPrefs.SetFloat("High", alive);
            bestTimeTxt.text = alive.ToString("N1");
        }
        
    }
    public void gameOver()
    {
        Invoke("dead", 0.3f);
       
    }

    public void addScore(int score)
    {
        totalScore++;
        scoreTxt.text = totalScore.ToString();
        if (totalScore > savedScore)
        {
            savedScore = totalScore;
            PlayerPrefs.SetInt("High", totalScore);
            bestScoreTxt.text = totalScore.ToString();
        }
    }

    void dead()
    {
        gameOverTxt.SetActive(true);
        Time.timeScale = 0.0f;
       
    }
}
