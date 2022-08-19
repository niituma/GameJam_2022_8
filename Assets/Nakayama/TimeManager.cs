using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    public bool finish { get; private set; }
    [SerializeField] Text _timeText;
    [SerializeField] GameObject finishText;
    [SerializeField] private float _seconds = 60;//¡‚ÌUpdate‚Ì‚Ì•b”
    float _oldSeconds = 60;//‘O‚ÌUpdate‚Ì‚Ì•b”


    void Update()
    {
        if (!finish) _seconds -= Time.deltaTime;

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
    

