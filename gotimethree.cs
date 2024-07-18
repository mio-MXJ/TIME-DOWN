using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


/// <summary>
///时间倒计时方法三
/// <summary>

public class gotimethree : MonoBehaviour
{
    private Text txtTimer;
    public int second = 120;//可以设置时间的倒计时
    private float totalTime;
    private void Start()
    {
        txtTimer = this.GetComponent<Text>();

    }
    private void Update()
    {
        Timer();
    }
    private void Timer()
    {
        totalTime += Time.deltaTime;
        if (totalTime >= 1)
        {
            second--;
            txtTimer.text=string.Format("{0:d2}:{1:d2}", second / 60, second % 60);
            totalTime = 0;
        }
    }
}
