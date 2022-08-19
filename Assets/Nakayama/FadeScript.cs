using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    [SerializeField] string _sceneName;
    [SerializeField] int goodScore = 5000;
    [SerializeField] int nomalScore = 2000;
    bool oneTime;
    FadeSystem _fade;
    TimeManager _timeManager;

    void Start()
    {
        _timeManager = GetComponent<TimeManager>();
        _fade = GetComponent<FadeSystem>();
    }

    void Update()
    {
        if (_timeManager.finish)
        {
            if (ScoreScript._scorePoint >= goodScore && GameManager._ngPoint >= 0)
            {
                _sceneName = "GoodEnding";
            }
            else if (ScoreScript._scorePoint >= nomalScore && GameManager._ngPoint >= 0)
            {
                _sceneName = "NomalEnding";
            }
            else
            {
                _sceneName = "BadEnding";
            }

            if (!oneTime)
            {
                oneTime = true;
                _fade.OnFadeOut(_sceneName);
            }
        }
    }
}
