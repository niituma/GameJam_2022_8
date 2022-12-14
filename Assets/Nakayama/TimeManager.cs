using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    public bool finish { get; private set; }
    [SerializeField] Text _timeText;
    [SerializeField] GameObject finishText;
    [SerializeField] private float _seconds = 60;//今のUpdateの時の秒数
    float _oldSeconds = 60;//前のUpdateの時の秒数

    private void Start()
    {
        _timeText.text = $"{((int)_seconds)}";
    }
    void Update()
    {
        if (!finish && FadeSystem._fadeInFinish) _seconds -= Time.deltaTime;

        if (_seconds <= -1)
        {
            finish = true;
            finishText.gameObject.SetActive(true);
        }

        if ((int)_seconds != (int)_oldSeconds)
        {
            _timeText.text = $"{((int)_seconds + 1)}";
        }
        _oldSeconds = _seconds;
    }
}
    

