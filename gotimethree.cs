using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


/// <summary>
///ʱ�䵹��ʱ������
/// <summary>

public class gotimethree : MonoBehaviour
{
    private Text txtTimer;
    public int second = 120;//��������ʱ��ĵ���ʱ
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
