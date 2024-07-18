using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


/// <summary>
///时间倒计时方法二
/// <summary>

public class gotimetwo : MonoBehaviour
{
    private Text txtTimer;
    public int second = 120;//可以设置时间的倒计时
    private float nextTime;
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
        
        if (Time.time >= nextTime)
        {
            second--;
            txtTimer.text=string.Format("{0:d2}:{1:d2}", second / 60, second % 60);
            nextTime = Time.time+1;
        }
    }
}
