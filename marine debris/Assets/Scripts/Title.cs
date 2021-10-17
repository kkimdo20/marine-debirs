using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Title : MonoBehaviour
{
    public string sceneName = "GameSelect";

    public void ClickStart()
    {
        Debug.Log("로딩");
        SceneManager.LoadScene(sceneName);
        
    }

    public void ClickExit()
    {
        Debug.Log("게임 종료");
        Application.Quit();
        
    }
}
