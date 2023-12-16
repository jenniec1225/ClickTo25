using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    #region Singleton
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    #endregion

    public void LoadMainGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Exit()
    {
        Application.Quit(); // 게임 종
    }
}
