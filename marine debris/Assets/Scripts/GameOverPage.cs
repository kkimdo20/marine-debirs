using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPage : MonoBehaviour
{
   
    
    public void ClickRetry()
    {
        Application.LoadLevel("GameSelect");
        Time.timeScale = 1f;
    }

    public void ClickExit()
    {
        Debug.Log("게임 종료");
        Application.LoadLevel("GameTitle");
        Time.timeScale = 1f;
    }
}

