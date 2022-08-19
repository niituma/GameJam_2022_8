using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    public bool finish { get; private set; }
    Text _timeText;

    [SerializeField] private float _seconds = 60;//¡‚ÌUpdate‚Ì‚Ì•b”
    float _oldSeconds = 60;//‘O‚ÌUpdate‚Ì‚Ì•b”

    private void Start()
    {
        _timeText = GetComponent<Text>();
    }

    void Update()
    {
        if (!finish) _seconds -= Time.deltaTime;

        if (_seconds <= -1)
        {
            finish = true;
        }

        if ((int)_seconds != (int)_oldSeconds)
        {
            _timeText.text = $"{((int)_seconds + 1)}";
        }
        _oldSeconds = _seconds;
    }
}
    

