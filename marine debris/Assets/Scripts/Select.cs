using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    // Start is called before the first frame update
    public void ClickJellyFish()
    {
        Debug.Log("�ε�");
        SceneManager.LoadScene("GameStage3");
    }

    public void ClickShark()
    {
        Debug.Log("�ε�");
        SceneManager.LoadScene("GameStage2");
    }

    public void ClickTurtle()
    {
        Debug.Log("�ε�");
        SceneManager.LoadScene("GameStage");
    }
}
