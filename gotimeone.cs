using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///ʱ�䵹��ʱ����һ
/// <summary>

public class gotimeone : MonoBehaviour
{
    private Text txtTimer;
    public int second = 120;//��������ʱ��ĵ���ʱ
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
        //����ʱʮ�������죨����Ҫ����ֱ��ɾ����
        if (second <= 10)
        {
            txtTimer.color = Color.red;
        }
    }
}
