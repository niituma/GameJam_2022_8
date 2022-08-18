using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScript : FadeSceneManager
{
    [SerializeField] string _sceneName;
    [SerializeField] FadeSceneManager _fade;
    [SerializeField]int goodScore = 5000;
    [SerializeField]int nomalScore = 2000;

    void Start()
    {
        string _sceneName = SceneManager.GetActiveScene().name;
        if (_sceneName == "Game") 
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

        }

    }

    void Update()
    {
        if(_sceneName == "Game" && TimeManager.finish) _fade.FadeScene(_sceneName, 1.5f);
        if (Input.GetButtonDown("Fire1")) _fade.FadeScene(_sceneName, 1.5f);
    }
}
