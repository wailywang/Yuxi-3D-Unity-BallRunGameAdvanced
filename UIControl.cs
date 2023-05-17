using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    //属性
    public Text ScoreText;
    public int score = 0;

    //单例模式
    public static UIControl _instance;
    private void Awake()
    {
        _instance = this;
    }

    //得分
    public void AddScore (int x)
    {
        score += x;
        ScoreText.text = "Score: " + score;
    }

}
