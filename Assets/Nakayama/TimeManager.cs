using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    [SerializeField] float _timecount = 60.0f;
    public bool finish { get; private set; }

    //public Text timeText;

    void Update()
    {
        if(!finish)_timecount -= Time.deltaTime;

        //時間を表示する
        //timeText.text = _timecount.ToString("f1") + "秒";

        if (_timecount <= 0)
        {
            //timeText.text = "時間になりました！";
            finish = true;
        }
    }
}
