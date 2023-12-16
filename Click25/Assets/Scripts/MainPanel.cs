using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanel : MonoBehaviour
{
    public void OnClickStartButton()
    {
        Debug.Log("게임 시작");
        GameManager.Instance.LoadMainGame();
    }

    public void OnClickExitButton()
    {
        Debug.Log("게임 종료");
        GameManager.Instance.Exit();
    }

  
}
