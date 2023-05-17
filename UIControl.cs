using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    //����
    public Text ScoreText;
    public int score = 0;

    //����ģʽ
    public static UIControl _instance;
    private void Awake()
    {
        _instance = this;
    }

    //�÷�
    public void AddScore (int x)
    {
        score += x;
        ScoreText.text = "Score: " + score;
    }

}
