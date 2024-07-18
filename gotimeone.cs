using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///时间倒计时方法一
/// <summary>

public class gotimeone : MonoBehaviour
{
    private Text txtTimer;
    public int second = 120;//可以设置时间的倒计时
    private void Start()
    {
        txtTimer = this.GetComponent<Text>();
        InvokeRepeating("Timer", 1, 1);

    }
   
    private void Timer()
    {
        second--;
        txtTimer.text = string.Format("{0:d2}:{1:d2}", second / 60, second % 60);
        if(second<=0)
        {
          CancelInvoke("Timer");
        }
        //倒计时十秒字体变红（不需要可以直接删除）
        if (second <= 10)
        {
            txtTimer.color = Color.red;
        }
    }
}
