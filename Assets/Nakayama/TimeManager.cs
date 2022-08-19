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

        //ŽžŠÔ‚ð•\Ž¦‚·‚é
        //timeText.text = _timecount.ToString("f1") + "•b";

        if (_timecount <= 0)
        {
            //timeText.text = "ŽžŠÔ‚É‚È‚è‚Ü‚µ‚½I";
            finish = true;
        }
    }
}
